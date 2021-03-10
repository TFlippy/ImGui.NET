using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiViewportP
    {
        public ImGuiViewport _ImGuiViewport;
        public fixed int DrawListsLastFrame[2];
        public ImDrawList* DrawLists_0;
        public ImDrawList* DrawLists_1;
        public ImDrawData DrawDataP;
        public ImDrawDataBuilder DrawDataBuilder;
        public Vector2 WorkOffsetMin;
        public Vector2 WorkOffsetMax;
        public Vector2 CurrWorkOffsetMin;
        public Vector2 CurrWorkOffsetMax;
    }
    public unsafe partial struct ImGuiViewportPPtr
    {
        public ImGuiViewportP* NativePtr { get; }
        public ImGuiViewportPPtr(ImGuiViewportP* nativePtr) => NativePtr = nativePtr;
        public ImGuiViewportPPtr(IntPtr nativePtr) => NativePtr = (ImGuiViewportP*)nativePtr;
        public static implicit operator ImGuiViewportPPtr(ImGuiViewportP* nativePtr) => new ImGuiViewportPPtr(nativePtr);
        public static implicit operator ImGuiViewportP* (ImGuiViewportPPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiViewportPPtr(IntPtr nativePtr) => new ImGuiViewportPPtr(nativePtr);
        public ref ImGuiViewport _ImGuiViewport => ref Unsafe.AsRef<ImGuiViewport>(&NativePtr->_ImGuiViewport);
        public RangeAccessor<int> DrawListsLastFrame => new RangeAccessor<int>(NativePtr->DrawListsLastFrame, 2);
        public ref ImDrawData DrawDataP => ref Unsafe.AsRef<ImDrawData>(&NativePtr->DrawDataP);
        public ref ImDrawDataBuilder DrawDataBuilder => ref Unsafe.AsRef<ImDrawDataBuilder>(&NativePtr->DrawDataBuilder);
        public ref Vector2 WorkOffsetMin => ref Unsafe.AsRef<Vector2>(&NativePtr->WorkOffsetMin);
        public ref Vector2 WorkOffsetMax => ref Unsafe.AsRef<Vector2>(&NativePtr->WorkOffsetMax);
        public ref Vector2 CurrWorkOffsetMin => ref Unsafe.AsRef<Vector2>(&NativePtr->CurrWorkOffsetMin);
        public ref Vector2 CurrWorkOffsetMax => ref Unsafe.AsRef<Vector2>(&NativePtr->CurrWorkOffsetMax);
        public void Destroy()
        {
            ImGuiNative.ImGuiViewportP_destroy((ImGuiViewportP*)(NativePtr));
        }
        public ImRect GetMainRect()
        {
            ImRect __retval;
            ImGuiNative.ImGuiViewportP_GetMainRect(&__retval, (ImGuiViewportP*)(NativePtr));
            return __retval;
        }
        public ImRect GetWorkRect()
        {
            ImRect __retval;
            ImGuiNative.ImGuiViewportP_GetWorkRect(&__retval, (ImGuiViewportP*)(NativePtr));
            return __retval;
        }
        public void UpdateWorkRect()
        {
            ImGuiNative.ImGuiViewportP_UpdateWorkRect((ImGuiViewportP*)(NativePtr));
        }
    }
}
