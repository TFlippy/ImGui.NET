namespace ImGuiNET
{
	public unsafe struct ImSpan<T> where T : unmanaged
	{
		public T* Data;
		public T* DataEnd;
	}
}
