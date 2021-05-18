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

		public string ToFormattedString()
		{
			var length = 0;
			var ptr = this.Data;
			var was_id = false;

			while (*ptr != 0)
			{
				if (was_id && *ptr == '#')
				{
					length--;
					ptr--;

					break;
				}
				was_id = *ptr == '#';

				length += 1;
				ptr += 1;
			}

			return Encoding.ASCII.GetString(this.Data, length);
		}

		public static implicit operator string(NullTerminatedString nts) => nts.ToString();
	}
}
