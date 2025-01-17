namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiButtonFlagsPrivate
    {
        ImGuiButtonFlags_PressedOnClick = 1 << 4,
        ImGuiButtonFlags_PressedOnClickRelease = 1 << 5,
        ImGuiButtonFlags_PressedOnClickReleaseAnywhere = 1 << 6,
        ImGuiButtonFlags_PressedOnRelease = 1 << 7,
        ImGuiButtonFlags_PressedOnDoubleClick = 1 << 8,
        ImGuiButtonFlags_PressedOnDragDropHold = 1 << 9,
        ImGuiButtonFlags_Repeat = 1 << 10,
        ImGuiButtonFlags_FlattenChildren = 1 << 11,
        ImGuiButtonFlags_AllowItemOverlap = 1 << 12,
        ImGuiButtonFlags_DontClosePopups = 1 << 13,
        ImGuiButtonFlags_Disabled = 1 << 14,
        ImGuiButtonFlags_AlignTextBaseLine = 1 << 15,
        ImGuiButtonFlags_NoKeyModifiers = 1 << 16,
        ImGuiButtonFlags_NoHoldingActiveId = 1 << 17,
        ImGuiButtonFlags_NoNavFocus = 1 << 18,
        ImGuiButtonFlags_NoHoveredOnFocus = 1 << 19,
        ImGuiButtonFlags_PressedOnMask = ImGuiButtonFlags_PressedOnClick | ImGuiButtonFlags_PressedOnClickRelease | ImGuiButtonFlags_PressedOnClickReleaseAnywhere | ImGuiButtonFlags_PressedOnRelease | ImGuiButtonFlags_PressedOnDoubleClick | ImGuiButtonFlags_PressedOnDragDropHold,
        ImGuiButtonFlags_PressedOnDefault = ImGuiButtonFlags_PressedOnClickRelease,
    }
}
