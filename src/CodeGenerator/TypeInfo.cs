using System.Collections.Generic;

namespace CodeGenerator
{
	public class TypeInfo
	{
		public static readonly Dictionary<string, string> WellKnownTypes = new Dictionary<string, string>()
		{
			{ "bool", "byte" },
			{ "unsigned char", "byte" },
			{ "signed char", "sbyte" },
			{ "char", "byte" },
			{ "ImWchar", "ushort" },
			{ "ImFileHandle", "IntPtr" },

			{ "ImU8", "byte" },
			{ "ImS8", "sbyte" },
			{ "ImU16", "ushort" },
			{ "ImS16", "short" },
			{ "ImU32", "uint" },
			{ "ImS32", "int" },
			{ "ImU64", "ulong" },
			{ "ImS64", "long" },

			{ "unsigned short", "ushort" },
			{ "unsigned int", "uint" },
			{ "ImVec2", "Vector2" },
			{ "ImVec2_Simple", "Vector2" },
			{ "ImVec3", "Vector3" },
			{ "ImVec4", "Vector4" },
			{ "ImWchar16", "ushort" }, //char is not blittable
            { "ImVec4_Simple", "Vector4" },
			{ "ImColor_Simple", "ImColor" },
			{ "ImTextureID", "IntPtr" },
			{ "ImGuiID", "uint" },
			{ "ImDrawIdx", "ushort" },
			//{ "ImDrawListSharedData", "IntPtr" },
			//{ "ImDrawListSharedData*", "IntPtr" },

			{ "ImGuiTableColumnIdx", "sbyte" },
			{ "ImGuiTableDrawChannelIdx", "byte" },

			{ "ImSpan_ImGuiTableColumn", "ImSpan<ImGuiTableColumn>" },
			{ "ImSpan_ImGuiTableColumnIdx", "ImSpan<sbyte>" },
			{ "ImSpan_ImGuiTableCellData", "ImSpan<ImGuiTableCellData>" },

			{ "ImPool_ImGuiTable", "ImPool<ImGuiTable>" },
			{ "ImPool_ImGuiTabBar", "ImPool<ImGuiTabBar>" },


			{ "ImDrawCallback", "void*" },
			{ "ImGuiContextHookCallback", "void*" },
			{ "ImGuiErrorLogCallback", "void*" },
			{ "ImGuiSizeCallback", "void*" },
			{ "ImGuiInputTextCallback", "delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData*, int>" },

			//{ "size_t", "uint" },
			{ "size_t", "nuint" }, // size_t varies by architecture
			//{ "ImGuiContext*", "IntPtr" },
			{ "float[2]", "Vector2*" },
			{ "float[3]", "Vector3*" },
			{ "float[4]", "Vector4*" },
			{ "int[2]", "int*" },
			{ "int[3]", "int*" },
			{ "int[4]", "int*" },
			{ "float&", "float*" },
			{ "ImVec2[2]", "Vector2*" },
			{ "char* []", "byte**" },
			{ "unsigned char[256]", "byte*"},
		};

		public static readonly Dictionary<string, string> WellKnownFieldReplacements = new Dictionary<string, string>()
		{
			{ "bool", "bool" }, // Force bool to remain as bool in type-safe wrappers.
        };

		public static readonly HashSet<string> CustomDefinedTypes = new HashSet<string>()
		{
			"ImVector",
			"ImVec2",
			"ImVec4",
			"ImGuiStoragePair",
			"ImGuiStyleMod",
			"ImGuiDataTypePrivate"
		};

		public static readonly Dictionary<string, string> WellKnownDefaultValues = new Dictionary<string, string>()
		{
			{ "((void *)0)", "null" },
			{ "NULL", "null" },
			{ "((void*)0)", "null" },
			{ "ImVec2(0,0)", "new Vector2()" },
			{ "ImVec2(-1,0)", "new Vector2(-1, 0)" },
			{ "ImVec2(1,0)", "new Vector2(1, 0)" },
			{ "ImVec2(1,1)", "new Vector2(1, 1)" },
			{ "ImVec2(0,1)", "new Vector2(0, 1)" },
			{ "ImVec2(0.0f,0.0f)", "new Vector2(0, 0)" },
			{ "ImVec4(0,0,0,0)", "new Vector4()" },
			{ "ImVec4(1,1,1,1)", "new Vector4(1, 1, 1, 1)" },
			{ "ImDrawCornerFlags_All", "ImDrawCornerFlags.All" },
			{ "ImGuiPopupFlags_None", "ImGuiPopupFlags.None" },
			{ "ImGuiNavHighlightFlags_TypeDefault", "ImGuiNavHighlightFlags.TypeDefault" },
			{ "ImGuiDataType_COUNT", "ImGuiDataType.COUNT" },
			{ "ImVec2(-FLT_MIN,0)", "new Vector2(-float.MinValue, 0)" },
			{ "FLT_MAX", "float.MaxValue" },
			{ "FLT_MIN", "float.MinValue" },
			{ "(((ImU32)(255)<<24)|((ImU32)(255)<<16)|((ImU32)(255)<<8)|((ImU32)(255)<<0))", "0xFFFFFFFF" }
		};

		public static readonly Dictionary<string, string> IdentifierReplacements = new Dictionary<string, string>()
		{
			{ "in", "@in" },
			{ "out", "@out" },
			{ "ref", "@ref" },
		};

		public static readonly HashSet<string> LegalFixedTypes = new HashSet<string>()
		{
			"byte",
			"sbyte",
			"char",
			"ushort",
			"short",
			"uint",
			"int",
			"ulong",
			"long",
			"float",
			"double",
		};

		public static readonly HashSet<string> SkippedFunctions = new HashSet<string>()
		{
			"igInputText",
			"igInputTextMultiline",
			"igInputTextEx",
			"igCalcTextSize",
			"igInputTextWithHint",
			"igErrorCheckEndFrameRecover",
			"igFindBestWindowPosForPopupEx",
			//"igGetAllocatorFunctions"
		};
	}
}