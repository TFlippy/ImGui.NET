using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodeGenerator
{
	internal class ImguiDefinitions
	{
		public EnumDefinition[] Enums;
		public TypeDefinition[] Types;
		public FunctionDefinition[] Functions;
		public Dictionary<string, MethodVariant> Variants;

		private static int GetInt(JToken token, string key)
		{
			var v = token[key];
			if (v == null) return 0;
			return v.ToObject<int>();
		}
		public void LoadFrom(string directory)
		{

			JObject typesJson;
			using (var fs = File.OpenText(Path.Combine(directory, "structs_and_enums.json")))
			using (var jr = new JsonTextReader(fs))
			{
				typesJson = JObject.Load(jr);
			}

			JObject functionsJson;
			using (var fs = File.OpenText(Path.Combine(directory, "definitions.json")))
			using (var jr = new JsonTextReader(fs))
			{
				functionsJson = JObject.Load(jr);
			}

			JObject variantsJson = null;
			if (File.Exists(Path.Combine(directory, "variants.json")))
			{
				using (var fs = File.OpenText(Path.Combine(AppContext.BaseDirectory, "variants.json")))
				using (var jr = new JsonTextReader(fs))
				{
					variantsJson = JObject.Load(jr);
				}
			}

			this.Variants = new Dictionary<string, MethodVariant>();
			foreach (var jt in variantsJson.Children())
			{
				var jp = (JProperty)jt;
				var methodVariants = jp.Values().Select(jv =>
				{
					return new ParameterVariant(jv["name"].ToString(), jv["type"].ToString(), jv["variants"].Select(s => s.ToString()).ToArray());
				}).ToArray();
				this.Variants.Add(jp.Name, new MethodVariant(jp.Name, methodVariants));
			}

			var typeLocations = typesJson["locations"];

			this.Enums = typesJson["enums"].Select(jt =>
			{
				var jp = (JProperty)jt;
				var name = jp.Name;
				if (typeLocations?[jp.Name]?.Value<string>() == "internal")
				{
					return null;
				}
				var elements = jp.Values().Select(v =>
				{
					return new EnumMember(v["name"].ToString(), v["value"].ToString());
				}).ToArray();
				return new EnumDefinition(name, elements);
			}).Where(x => x != null).ToArray();

			this.Types = typesJson["structs"].Select(jt =>
			{
				var jp = (JProperty)jt;
				var name = jp.Name;
				if (typeLocations?[jp.Name]?.Value<string>() == "internal")
				{
					return null;
				}
				var fields = jp.Values().Select(v =>
				{
					if (v["type"].ToString().Contains("static")) { return null; }


					return new TypeReference(
						v["name"].ToString(),
						v["type"].ToString(),
							GetInt(v, "size"),
						v["template_type"]?.ToString(),
						this.Enums);
				}).Where(tr => tr != null).ToArray();
				return new TypeDefinition(name, fields);
			}).Where(x => x != null).ToArray();

			this.Functions = functionsJson.Children().Select(jt =>
			{
				var jp = (JProperty)jt;
				var name = jp.Name;
				var hasNonUdtVariants = jp.Values().Any(val => val["ov_cimguiname"]?.ToString().EndsWith("nonUDT") ?? false);
				var overloads = jp.Values().Select(val =>
				{
					var ov_cimguiname = val["ov_cimguiname"]?.ToString();
					var cimguiname = val["cimguiname"].ToString();
					var friendlyName = val["funcname"]?.ToString();
					if (cimguiname.EndsWith("_destroy"))
					{
						friendlyName = "Destroy";
					}
					//skip internal functions
					var typename = val["stname"]?.ToString();
					if (!string.IsNullOrEmpty(typename))
					{
						if (!this.Types.Any(x => x.Name == val["stname"]?.ToString()))
						{
							return null;
						}
					}
					if (friendlyName == null) { return null; }
					if (val["location"]?.ToString() == "internal") return null;

					var exportedName = ov_cimguiname;
					if (exportedName == null)
					{
						exportedName = cimguiname;
					}

					if (hasNonUdtVariants && !exportedName.EndsWith("nonUDT2"))
					{
						return null;
					}

					string selfTypeName = null;
					var underscoreIndex = exportedName.IndexOf('_');
					if (underscoreIndex > 0 && !exportedName.StartsWith("ig")) // Hack to exclude some weirdly-named non-instance functions.
					{
						selfTypeName = exportedName.Substring(0, underscoreIndex);
					}

					var parameters = new List<TypeReference>();

					// find any variants that can be applied to the parameters of this method based on the method name
					MethodVariant methodVariants = null;
					this.Variants.TryGetValue(jp.Name, out methodVariants);

					foreach (var p in val["argsT"])
					{
						var pType = p["type"].ToString();
						var pName = p["name"].ToString();

						// if there are possible variants for this method then try to match them based on the parameter name and expected type
						var matchingVariant = methodVariants?.Parameters.Where(pv => pv.Name == pName && pv.OriginalType == pType).FirstOrDefault() ?? null;
						if (matchingVariant != null) matchingVariant.Used = true;

						parameters.Add(new TypeReference(pName, pType, 0, this.Enums, matchingVariant?.VariantTypes));
					}

					var defaultValues = new Dictionary<string, string>();
					foreach (var dv in val["defaults"])
					{
						var dvProp = (JProperty)dv;
						defaultValues.Add(dvProp.Name, dvProp.Value.ToString());
					}
					var returnType = val["ret"]?.ToString() ?? "void";
					string comment = null;

					var structName = val["stname"].ToString();
					var isConstructor = val.Value<bool>("constructor");
					var isDestructor = val.Value<bool>("destructor");
					if (isConstructor)
					{
						returnType = structName + "*";
					}

					return new OverloadDefinition(
						exportedName,
						friendlyName,
						parameters.ToArray(),
						defaultValues,
						returnType,
						structName,
						comment,
						isConstructor,
						isDestructor);
				}).Where(od => od != null).ToArray();
				if (overloads.Length == 0) return null;
				return new FunctionDefinition(name, overloads, this.Enums);
			}).Where(x => x != null).OrderBy(fd => fd.Name).ToArray();
		}
	}

	internal class MethodVariant
	{
		public string Name { get; }

		public ParameterVariant[] Parameters { get; }

		public MethodVariant(string name, ParameterVariant[] parameters)
		{
			this.Name = name;
			this.Parameters = parameters;
		}
	}

	internal class ParameterVariant
	{
		public string Name { get; }

		public string OriginalType { get; }

		public string[] VariantTypes { get; }

		public bool Used { get; set; }

		public ParameterVariant(string name, string originalType, string[] variantTypes)
		{
			this.Name = name;
			this.OriginalType = originalType;
			this.VariantTypes = variantTypes;
			this.Used = false;
		}
	}

	internal class EnumDefinition
	{
		private readonly Dictionary<string, string> _sanitizedNames;

		public string Name { get; }
		public string FriendlyName { get; }
		public EnumMember[] Members { get; }

		public EnumDefinition(string name, EnumMember[] elements)
		{
			this.Name = name;
			if (this.Name.EndsWith('_'))
			{
				this.FriendlyName = this.Name.Substring(0, this.Name.Length - 1);
			}
			else
			{
				this.FriendlyName = this.Name;
			}
			this.Members = elements;

			this._sanitizedNames = new Dictionary<string, string>();
			foreach (var el in elements)
			{
				this._sanitizedNames.Add(el.Name, this.SanitizeMemberName(el.Name));
			}
		}

		public string SanitizeNames(string text)
		{
			foreach (var kvp in this._sanitizedNames)
			{
				text = text.Replace(kvp.Key, kvp.Value);
			}

			return text;
		}

		private string SanitizeMemberName(string memberName)
		{
			var ret = memberName;
			if (memberName.StartsWith(this.Name))
			{
				ret = memberName.Substring(this.Name.Length);
			}

			if (ret.EndsWith('_'))
			{
				ret = ret.Substring(0, ret.Length - 1);
			}

			return ret;
		}
	}

	internal class EnumMember
	{
		public EnumMember(string name, string value)
		{
			this.Name = name;
			this.Value = value;
		}

		public string Name { get; }
		public string Value { get; }
	}

	internal class TypeDefinition
	{
		public string Name { get; }
		public TypeReference[] Fields { get; }

		public TypeDefinition(string name, TypeReference[] fields)
		{
			this.Name = name;
			this.Fields = fields;
		}
	}

	internal class TypeReference
	{
		public string Name { get; }
		public string Type { get; }
		public string TemplateType { get; }
		public int ArraySize { get; }
		public bool IsFunctionPointer { get; }
		public string[] TypeVariants { get; }
		public bool IsEnum { get; }

		public TypeReference(string name, string type, int asize, EnumDefinition[] enums)
			: this(name, type, asize, null, enums, null) { }

		public TypeReference(string name, string type, int asize, EnumDefinition[] enums, string[] typeVariants)
			: this(name, type, asize, null, enums, typeVariants) { }

		public TypeReference(string name, string type, int asize, string templateType, EnumDefinition[] enums)
			: this(name, type, asize, templateType, enums, null) { }

		public TypeReference(string name, string type, int asize, string templateType, EnumDefinition[] enums, string[] typeVariants)
		{
			this.Name = name;
			this.Type = type.Replace("const", string.Empty).Trim();


			if (this.Type.StartsWith("ImVector_"))
			{
				if (this.Type.EndsWith("*"))
				{
					this.Type = "ImVector*";
				}
				else
				{
					this.Type = "ImVector";
				}
			}

			if (this.Type.StartsWith("ImChunkStream_"))
			{
				if (this.Type.EndsWith("*"))
				{
					this.Type = "ImChunkStream*";
				}
				else
				{
					this.Type = "ImChunkStream";
				}
			}

			this.TemplateType = templateType;
			this.ArraySize = asize;
			var startBracket = name.IndexOf('[');
			if (startBracket != -1)
			{
				//This is only for older cimgui binding jsons
				var endBracket = name.IndexOf(']');
				var sizePart = name.Substring(startBracket + 1, endBracket - startBracket - 1);
				if (this.ArraySize == 0)
					this.ArraySize = this.ParseSizeString(sizePart, enums);
				this.Name = this.Name.Substring(0, startBracket);
			}
			this.IsFunctionPointer = this.Type.IndexOf('(') != -1;

			this.TypeVariants = typeVariants;

			this.IsEnum = enums.Any(t => t.Name == type || t.FriendlyName == type);
		}

		private int ParseSizeString(string sizePart, EnumDefinition[] enums)
		{
			var plusStart = sizePart.IndexOf('+');
			if (plusStart != -1)
			{
				var first = sizePart.Substring(0, plusStart);
				var second = sizePart.Substring(plusStart, sizePart.Length - plusStart);
				var firstVal = int.Parse(first);
				var secondVal = int.Parse(second);
				return firstVal + secondVal;
			}

			if (!int.TryParse(sizePart, out var ret))
			{
				foreach (var ed in enums)
				{
					if (sizePart.StartsWith(ed.Name))
					{
						foreach (var member in ed.Members)
						{
							if (member.Name == sizePart)
							{
								return int.Parse(member.Value);
							}
						}
					}
				}

				ret = -1;
			}

			return ret;
		}

		public TypeReference WithVariant(int variantIndex, EnumDefinition[] enums)
		{
			if (variantIndex == 0) return this;
			else return new TypeReference(this.Name, this.TypeVariants[variantIndex - 1], this.ArraySize, this.TemplateType, enums);
		}
	}

	internal class FunctionDefinition
	{
		public string Name { get; }
		public OverloadDefinition[] Overloads { get; }

		public FunctionDefinition(string name, OverloadDefinition[] overloads, EnumDefinition[] enums)
		{
			this.Name = name;
			this.Overloads = this.ExpandOverloadVariants(overloads, enums);
		}

		private OverloadDefinition[] ExpandOverloadVariants(OverloadDefinition[] overloads, EnumDefinition[] enums)
		{
			var newDefinitions = new List<OverloadDefinition>();

			foreach (var overload in overloads)
			{
				var hasVariants = false;
				var variantCounts = new int[overload.Parameters.Length];

				for (var i = 0; i < overload.Parameters.Length; i++)
				{
					if (overload.Parameters[i].TypeVariants != null)
					{
						hasVariants = true;
						variantCounts[i] = overload.Parameters[i].TypeVariants.Length + 1;
					}
					else
					{
						variantCounts[i] = 1;
					}
				}

				if (hasVariants)
				{
					var totalVariants = variantCounts[0];
					for (var i = 1; i < variantCounts.Length; i++) totalVariants *= variantCounts[i];

					for (var i = 0; i < totalVariants; i++)
					{
						var parameters = new TypeReference[overload.Parameters.Length];
						var div = 1;

						for (var j = 0; j < parameters.Length; j++)
						{
							var k = (i / div) % variantCounts[j];

							parameters[j] = overload.Parameters[j].WithVariant(k, enums);

							if (j > 0) div *= variantCounts[j];
						}

						newDefinitions.Add(overload.WithParameters(parameters));
					}
				}
				else
				{
					newDefinitions.Add(overload);
				}
			}

			return newDefinitions.ToArray();
		}
	}

	internal class OverloadDefinition
	{
		public string ExportedName { get; }
		public string FriendlyName { get; }
		public TypeReference[] Parameters { get; }
		public Dictionary<string, string> DefaultValues { get; }
		public string ReturnType { get; }
		public string StructName { get; }
		public bool IsMemberFunction { get; }
		public string Comment { get; }
		public bool IsConstructor { get; }
		public bool IsDestructor { get; }

		public OverloadDefinition(
			string exportedName,
			string friendlyName,
			TypeReference[] parameters,
			Dictionary<string, string> defaultValues,
			string returnType,
			string structName,
			string comment,
			bool isConstructor,
			bool isDestructor)
		{
			this.ExportedName = exportedName;
			this.FriendlyName = friendlyName;
			this.Parameters = parameters;
			this.DefaultValues = defaultValues;
			this.ReturnType = returnType.Replace("const", string.Empty).Replace("inline", string.Empty).Trim();
			this.StructName = structName;
			this.IsMemberFunction = !string.IsNullOrEmpty(structName);
			this.Comment = comment;
			this.IsConstructor = isConstructor;
			this.IsDestructor = isDestructor;
		}

		public OverloadDefinition WithParameters(TypeReference[] parameters)
		{
			return new OverloadDefinition(this.ExportedName, this.FriendlyName, parameters, this.DefaultValues, this.ReturnType, this.StructName, this.Comment, this.IsConstructor, this.IsDestructor);
		}
	}
}
