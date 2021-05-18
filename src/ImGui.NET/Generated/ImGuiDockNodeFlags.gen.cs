namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiDockNodeFlags
    {
        None = 0,
        KeepAliveOnly = 1 << 0,
        NoDockingInCentralNode = 1 << 2,
        PassthruCentralNode = 1 << 3,
        NoSplit = 1 << 4,
        NoResize = 1 << 5,
        AutoHideTabBar = 1 << 6,
		ImGuiDockNodeFlags_DockSpace = 1 << 10,
		ImGuiDockNodeFlags_CentralNode = 1 << 11,
		ImGuiDockNodeFlags_NoTabBar = 1 << 12,
		ImGuiDockNodeFlags_HiddenTabBar = 1 << 13,
		ImGuiDockNodeFlags_NoWindowMenuButton = 1 << 14,
		ImGuiDockNodeFlags_NoCloseButton = 1 << 15,
		ImGuiDockNodeFlags_NoDocking = 1 << 16,
		ImGuiDockNodeFlags_NoDockingSplitMe = 1 << 17,
		ImGuiDockNodeFlags_NoDockingSplitOther = 1 << 18,
		ImGuiDockNodeFlags_NoDockingOverMe = 1 << 19,
		ImGuiDockNodeFlags_NoDockingOverOther = 1 << 20,
		ImGuiDockNodeFlags_NoResizeX = 1 << 21,
		ImGuiDockNodeFlags_NoResizeY = 1 << 22,
		ImGuiDockNodeFlags_SharedFlagsInheritMask = ~0,
		ImGuiDockNodeFlags_NoResizeFlagsMask = ImGuiDockNodeFlags.NoResize | ImGuiDockNodeFlags.ImGuiDockNodeFlags_NoResizeX | ImGuiDockNodeFlags.ImGuiDockNodeFlags_NoResizeY,
		ImGuiDockNodeFlags_LocalFlagsMask = ImGuiDockNodeFlags.NoSplit | ImGuiDockNodeFlags_NoResizeFlagsMask | ImGuiDockNodeFlags.AutoHideTabBar | ImGuiDockNodeFlags_DockSpace | ImGuiDockNodeFlags_CentralNode | ImGuiDockNodeFlags_NoTabBar | ImGuiDockNodeFlags_HiddenTabBar | ImGuiDockNodeFlags_NoWindowMenuButton | ImGuiDockNodeFlags_NoCloseButton | ImGuiDockNodeFlags_NoDocking,
		ImGuiDockNodeFlags_LocalFlagsTransferMask = ImGuiDockNodeFlags_LocalFlagsMask & ~ImGuiDockNodeFlags_DockSpace,
		ImGuiDockNodeFlags_SavedFlagsMask = ImGuiDockNodeFlags_NoResizeFlagsMask | ImGuiDockNodeFlags_DockSpace | ImGuiDockNodeFlags_CentralNode | ImGuiDockNodeFlags_NoTabBar | ImGuiDockNodeFlags_HiddenTabBar | ImGuiDockNodeFlags_NoWindowMenuButton | ImGuiDockNodeFlags_NoCloseButton | ImGuiDockNodeFlags_NoDocking,

	}
}
