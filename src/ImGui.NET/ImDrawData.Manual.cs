namespace ImGuiNET
{
	public unsafe partial struct ImDrawDataPtr
	{
		public RangePtrAccessor<ImDrawListPtr> CmdListsRange => new RangePtrAccessor<ImDrawListPtr>(this.CmdLists.ToPointer(), this.CmdListsCount);
	}
}
