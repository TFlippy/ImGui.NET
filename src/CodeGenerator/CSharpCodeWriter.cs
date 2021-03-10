using System;
using System.IO;

namespace CodeGenerator
{
	internal class CSharpCodeWriter: IDisposable
	{
		private readonly StreamWriter _sw;
		private int _indentLevel = 0;

		public CSharpCodeWriter(string outputPath)
		{
			this._sw = File.CreateText(outputPath);
		}

		public void Using(string ns)
		{
			this.WriteIndented($"using {ns};");
		}

		public void PushBlock(string blockHeader)
		{
			this.WriteIndented(blockHeader);
			this.WriteIndented("{");
			this._indentLevel += 4;
		}

		public void PopBlock()
		{
			this._indentLevel -= 4;
			this.WriteIndented("}");
		}

		public void WriteLine(string text)
		{
			this.WriteIndented(text);
		}

		private void WriteIndented(string text)
		{
			for (var i = 0; i < this._indentLevel; i++)
			{
				this._sw.Write(' ');
			}
			this._sw.WriteLine(text);
		}

		public void Dispose()
		{
			this._sw.Dispose();
		}
	}
}
