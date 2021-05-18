namespace ImGuiNET
{
	public unsafe struct ImPool<T> where T : unmanaged
	{
		public ImVector<T> Buf;
		public ImGuiStorage Map;
		public int FreeIdx;
	}
}
