using System;

namespace ImGuiNET
{
	public unsafe partial struct ImGuiItemFlagsPtr
	{
		public ImGuiItemFlags* NativePtr { get; }
		public ImGuiItemFlagsPtr(ImGuiItemFlags* nativePtr) => NativePtr = nativePtr;
		public ImGuiItemFlagsPtr(IntPtr nativePtr) => NativePtr = (ImGuiItemFlags*)nativePtr;
		public static implicit operator ImGuiItemFlagsPtr(ImGuiItemFlags* nativePtr) => new ImGuiItemFlagsPtr(nativePtr);
		public static implicit operator ImGuiItemFlags*(ImGuiItemFlagsPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiItemFlagsPtr(IntPtr nativePtr) => new ImGuiItemFlagsPtr(nativePtr);
	}
}
