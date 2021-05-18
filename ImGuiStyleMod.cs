using System.Runtime.InteropServices;

namespace ImGuiNET
{
	public unsafe struct ImGuiStyleMod
	{
		public ImGuiStyleVar VarIdx;
		public Union union;

		[StructLayout(LayoutKind.Explicit, Size = 8)]
		public struct Union
		{
			[FieldOffset(0)]
			public fixed int BackupInt[2];

			[FieldOffset(0)]
			public fixed float BackupFloat[2];
		}
	}
}
