using System.Text;

namespace ImGuiNET
{
	public unsafe struct NullTerminatedString
	{
		public readonly byte* Data;

		public NullTerminatedString(byte* data)
		{
			this.Data = data;
		}

		public override string ToString()
		{
			var length = 0;
			var ptr = this.Data;
			while (*ptr != 0)
			{
				length += 1;
				ptr += 1;
			}

			return Encoding.ASCII.GetString(this.Data, length);
		}

		public static implicit operator string(NullTerminatedString nts) => nts.ToString();
	}
}
