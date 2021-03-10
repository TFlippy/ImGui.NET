namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiViewportFlags
    {
        None = 0,
        IsPlatformWindow = 1 << 0,
        IsPlatformMonitor = 1 << 1,
        OwnedByApp = 1 << 2,
    }
}
