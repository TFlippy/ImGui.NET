using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace ImGuiNET
{
	public static unsafe partial class ImGuiNative
	{
		[SuppressGCTransition]
		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetRemainingSpace(Vector2* pOut);

		[SuppressGCTransition]
		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetLineStart(Vector2* pOut);

		[SuppressGCTransition]
		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetCursorMaxPos(Vector2* pOut);

		[SuppressGCTransition]
		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igGetCurrentLineSize(Vector2* pOut);

		[SuppressGCTransition]
		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igSetCurrentLineSize(Vector2 size);

		[SuppressGCTransition]
		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igBeginGroup2(Vector2 size);

		[SuppressGCTransition]
		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igEndGroup2();

		[SuppressGCTransition]
		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igResetLine(float offset_x, float offset_y);

		[SuppressGCTransition]
		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igNewLine2(float height);

		[SuppressGCTransition]
		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igTextEx2(byte* text, byte* text_end, ImGuiTextFlags flags, ImFont* font, float font_size, uint color, uint color_bg, Vector2 offset_bg);

		[SuppressGCTransition]
		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void igCalcTextSize2(byte* text, byte* text_end, byte hide_text_after_double_hash, float wrap_width, float font_size, ImFont* font, Vector2* pOut);

		[SuppressGCTransition]
		[DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawList_AddLine2(ImDrawList* self, Vector2 p1, Vector2 p2, uint col0, uint col1, float thickness0, float thickness1);
	}

	public static unsafe partial class ImGui
	{
		public static void BeginGroup2(Vector2 size)
		{
			ImGuiNative.igBeginGroup2(size);
		}

		public static void EndGroup2()
		{
			ImGuiNative.igEndGroup2();
		}

		public static void ResetLine(float offset_x, float offset_y)
		{
			ImGuiNative.igResetLine(offset_x, offset_y);
		}

		public static Vector2 GetCurrentLineSize()
		{
			Vector2 __retval;
			ImGuiNative.igGetCurrentLineSize(&__retval);
			return __retval;
		}

		public static Vector2 GetCursorMaxPos()
		{
			Vector2 __retval;
			ImGuiNative.igGetCursorMaxPos(&__retval);
			return __retval;
		}

		public static void SetCurrentLineSize(Vector2 size)
		{
			ImGuiNative.igSetCurrentLineSize(size);
		}

		public static Vector2 GetRemainingSpace()
		{
			Vector2 __retval;
			ImGuiNative.igGetRemainingSpace(&__retval);
			return __retval;
		}

		public static Vector2 GetLineStart()
		{
			Vector2 __retval;
			ImGuiNative.igGetLineStart(&__retval);
			return __retval;
		}

		public static bool InputText(
			ReadOnlySpan<char> label,
			byte[] buf,
			uint buf_size)
		{
			return InputText(label, buf, buf_size, 0, null, IntPtr.Zero);
		}

		public static bool InputText(
			ReadOnlySpan<char> label,
			byte[] buf,
			uint buf_size,
			ImGuiInputTextFlags flags)
		{
			return InputText(label, buf, buf_size, flags, null, IntPtr.Zero);
		}

		public static bool InputText(
			ReadOnlySpan<char> label,
			byte[] buf,
			uint buf_size,
			ImGuiInputTextFlags flags,
			delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData*, int> callback)
		{
			return InputText(label, buf, buf_size, flags, callback, IntPtr.Zero);
		}

		public static unsafe bool InputText(
			ReadOnlySpan<char> label,
			byte[] buf,
			uint buf_size,
			ImGuiInputTextFlags flags,
			delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData*, int> callback,
			IntPtr user_data)
		{
			var utf8LabelByteCount = Encoding.UTF8.GetByteCount(label);
			byte* utf8LabelBytes;
			if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
			{
				utf8LabelBytes = Util.Allocate(utf8LabelByteCount + 1);
			}
			else
			{
				var stackPtr = stackalloc byte[utf8LabelByteCount + 1];
				utf8LabelBytes = stackPtr;
			}
			Util.GetUtf8(label, utf8LabelBytes, utf8LabelByteCount);

			bool ret;
			fixed (byte* bufPtr = buf)
			{
				ret = ImGuiNative.igInputText(utf8LabelBytes, bufPtr, buf_size, flags, callback, user_data.ToPointer()) != 0;
			}

			if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(utf8LabelBytes);
			}

			return ret;
		}

		public static bool InputText(
			ReadOnlySpan<char> label,
			ref string input,
			uint maxLength)
		{
			return InputText(label, ref input, maxLength, 0, null, IntPtr.Zero);
		}

		public static bool InputText(
			ReadOnlySpan<char> label,
			ref string input,
			uint maxLength,
			ImGuiInputTextFlags flags)
		{
			return InputText(label, ref input, maxLength, flags, null, IntPtr.Zero);
		}

		public static bool InputText(
			ReadOnlySpan<char> label,
			ref string input,
			uint maxLength,
			ImGuiInputTextFlags flags,
			delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData*, int> callback)
		{
			return InputText(label, ref input, maxLength, flags, callback, IntPtr.Zero);
		}

		public static bool InputText(
			ReadOnlySpan<char> label,
			ref string input,
			uint maxLength,
			ImGuiInputTextFlags flags,
			delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData*, int> callback,
			IntPtr user_data)
		{
			var utf8LabelByteCount = Encoding.UTF8.GetByteCount(label);
			byte* utf8LabelBytes;
			if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
			{
				utf8LabelBytes = Util.Allocate(utf8LabelByteCount + 1);
			}
			else
			{
				var stackPtr = stackalloc byte[utf8LabelByteCount + 1];
				utf8LabelBytes = stackPtr;
			}
			Util.GetUtf8(label, utf8LabelBytes, utf8LabelByteCount);

			var utf8InputByteCount = Encoding.UTF8.GetByteCount(input);
			var inputBufSize = Math.Max((int)maxLength + 1, utf8InputByteCount + 1);

			byte* utf8InputBytes;
			byte* originalUtf8InputBytes;
			if (inputBufSize > Util.StackAllocationSizeLimit)
			{
				utf8InputBytes = Util.Allocate(inputBufSize);
				originalUtf8InputBytes = Util.Allocate(inputBufSize);
			}
			else
			{
				var inputStackBytes = stackalloc byte[inputBufSize];
				utf8InputBytes = inputStackBytes;
				var originalInputStackBytes = stackalloc byte[inputBufSize];
				originalUtf8InputBytes = originalInputStackBytes;
			}
			Util.GetUtf8(input, utf8InputBytes, inputBufSize);
			var clearBytesCount = (uint)(inputBufSize - utf8InputByteCount);
			Unsafe.InitBlockUnaligned(utf8InputBytes + utf8InputByteCount, 0, clearBytesCount);
			Unsafe.CopyBlock(originalUtf8InputBytes, utf8InputBytes, (uint)inputBufSize);

			var result = ImGuiNative.igInputText(
				utf8LabelBytes,
				utf8InputBytes,
				(uint)inputBufSize,
				flags,
				callback,
				user_data.ToPointer());
			if (!Util.AreStringsEqual(originalUtf8InputBytes, inputBufSize, utf8InputBytes))
			{
				input = Util.StringFromPtr(utf8InputBytes);
			}

			if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(utf8LabelBytes);
			}
			if (inputBufSize > Util.StackAllocationSizeLimit)
			{
				Util.Free(utf8InputBytes);
				Util.Free(originalUtf8InputBytes);
			}

			return result != 0;
		}

		public static bool InputTextMultiline(
			ReadOnlySpan<char> label,
			ref string input,
			uint maxLength,
			Vector2 size)
		{
			return InputTextMultiline(label, ref input, maxLength, size, 0, null, IntPtr.Zero);
		}

		public static bool InputTextMultiline(
			ReadOnlySpan<char> label,
			ref string input,
			uint maxLength,
			Vector2 size,
			ImGuiInputTextFlags flags)
		{
			return InputTextMultiline(label, ref input, maxLength, size, flags, null, IntPtr.Zero);
		}

		public static bool InputTextMultiline(
			ReadOnlySpan<char> label,
			ref string input,
			uint maxLength,
			Vector2 size,
			ImGuiInputTextFlags flags,
			delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData*, int> callback)
		{
			return InputTextMultiline(label, ref input, maxLength, size, flags, callback, IntPtr.Zero);
		}

		public static bool InputTextMultiline(
			ReadOnlySpan<char> label,
			ref string input,
			uint maxLength,
			Vector2 size,
			ImGuiInputTextFlags flags,
			delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData*, int> callback,
			IntPtr user_data)
		{
			var utf8LabelByteCount = Encoding.UTF8.GetByteCount(label);
			byte* utf8LabelBytes;
			if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
			{
				utf8LabelBytes = Util.Allocate(utf8LabelByteCount + 1);
			}
			else
			{
				var stackPtr = stackalloc byte[utf8LabelByteCount + 1];
				utf8LabelBytes = stackPtr;
			}
			Util.GetUtf8(label, utf8LabelBytes, utf8LabelByteCount);

			var utf8InputByteCount = Encoding.UTF8.GetByteCount(input);
			var inputBufSize = Math.Max((int)maxLength + 1, utf8InputByteCount + 1);

			byte* utf8InputBytes;
			byte* originalUtf8InputBytes;
			if (inputBufSize > Util.StackAllocationSizeLimit)
			{
				utf8InputBytes = Util.Allocate(inputBufSize);
				originalUtf8InputBytes = Util.Allocate(inputBufSize);
			}
			else
			{
				var inputStackBytes = stackalloc byte[inputBufSize];
				utf8InputBytes = inputStackBytes;
				var originalInputStackBytes = stackalloc byte[inputBufSize];
				originalUtf8InputBytes = originalInputStackBytes;
			}
			Util.GetUtf8(input, utf8InputBytes, inputBufSize);
			var clearBytesCount = (uint)(inputBufSize - utf8InputByteCount);
			Unsafe.InitBlockUnaligned(utf8InputBytes + utf8InputByteCount, 0, clearBytesCount);
			Unsafe.CopyBlock(originalUtf8InputBytes, utf8InputBytes, (uint)inputBufSize);

			var result = ImGuiNative.igInputTextMultiline(
				utf8LabelBytes,
				utf8InputBytes,
				(uint)inputBufSize,
				size,
				flags,
				callback,
				user_data.ToPointer());
			if (!Util.AreStringsEqual(originalUtf8InputBytes, inputBufSize, utf8InputBytes))
			{
				input = Util.StringFromPtr(utf8InputBytes);
			}

			if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(utf8LabelBytes);
			}
			if (inputBufSize > Util.StackAllocationSizeLimit)
			{
				Util.Free(utf8InputBytes);
				Util.Free(originalUtf8InputBytes);
			}

			return result != 0;
		}

		public static bool InputTextWithHint(
			ReadOnlySpan<char> label,
			ReadOnlySpan<char> hint,
			ref string input,
			uint maxLength)
		{
			return InputTextWithHint(label, hint, ref input, maxLength, 0, null, IntPtr.Zero);
		}

		public static bool InputTextWithHint(
			ReadOnlySpan<char> label,
			ReadOnlySpan<char> hint,
			ref string input,
			uint maxLength,
			ImGuiInputTextFlags flags)
		{
			return InputTextWithHint(label, hint, ref input, maxLength, flags, null, IntPtr.Zero);
		}

		public static bool InputTextWithHint(
			ReadOnlySpan<char> label,
			ReadOnlySpan<char> hint,
			ref string input,
			uint maxLength,
			ImGuiInputTextFlags flags,
			delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData*, int> callback)
		{
			return InputTextWithHint(label, hint, ref input, maxLength, flags, callback, IntPtr.Zero);
		}

		public static bool InputTextWithHint(
			ReadOnlySpan<char> label,
			ReadOnlySpan<char> hint,
			ref string input,
			uint maxLength,
			ImGuiInputTextFlags flags,
			delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData*, int> callback,
			IntPtr user_data)
		{
			var utf8LabelByteCount = Encoding.UTF8.GetByteCount(label);
			byte* utf8LabelBytes;
			if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
			{
				utf8LabelBytes = Util.Allocate(utf8LabelByteCount + 1);
			}
			else
			{
				var stackPtr = stackalloc byte[utf8LabelByteCount + 1];
				utf8LabelBytes = stackPtr;
			}
			Util.GetUtf8(label, utf8LabelBytes, utf8LabelByteCount);

			var utf8HintByteCount = Encoding.UTF8.GetByteCount(hint);
			byte* utf8HintBytes;
			if (utf8HintByteCount > Util.StackAllocationSizeLimit)
			{
				utf8HintBytes = Util.Allocate(utf8HintByteCount + 1);
			}
			else
			{
				var stackPtr = stackalloc byte[utf8HintByteCount + 1];
				utf8HintBytes = stackPtr;
			}
			Util.GetUtf8(hint, utf8HintBytes, utf8HintByteCount);

			var utf8InputByteCount = Encoding.UTF8.GetByteCount(input);
			var inputBufSize = Math.Max((int)maxLength + 1, utf8InputByteCount + 1);

			byte* utf8InputBytes;
			byte* originalUtf8InputBytes;
			if (inputBufSize > Util.StackAllocationSizeLimit)
			{
				utf8InputBytes = Util.Allocate(inputBufSize);
				originalUtf8InputBytes = Util.Allocate(inputBufSize);
			}
			else
			{
				var inputStackBytes = stackalloc byte[inputBufSize];
				utf8InputBytes = inputStackBytes;
				var originalInputStackBytes = stackalloc byte[inputBufSize];
				originalUtf8InputBytes = originalInputStackBytes;
			}
			Util.GetUtf8(input, utf8InputBytes, inputBufSize);
			var clearBytesCount = (uint)(inputBufSize - utf8InputByteCount);
			Unsafe.InitBlockUnaligned(utf8InputBytes + utf8InputByteCount, 0, clearBytesCount);
			Unsafe.CopyBlock(originalUtf8InputBytes, utf8InputBytes, (uint)inputBufSize);

			var result = ImGuiNative.igInputTextWithHint(
				utf8LabelBytes,
				utf8HintBytes,
				utf8InputBytes,
				(uint)inputBufSize,
				flags,
				callback,
				user_data.ToPointer());
			if (!Util.AreStringsEqual(originalUtf8InputBytes, inputBufSize, utf8InputBytes))
			{
				input = Util.StringFromPtr(utf8InputBytes);
			}

			if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(utf8LabelBytes);
			}
			if (utf8HintByteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(utf8HintBytes);
			}
			if (inputBufSize > Util.StackAllocationSizeLimit)
			{
				Util.Free(utf8InputBytes);
				Util.Free(originalUtf8InputBytes);
			}

			return result != 0;
		}

		public static Vector2 CalcTextSize(string text)
		{
			return CalcTextSizeImpl(text);
		}

		public static Vector2 CalcTextSize(string text, int start)
		{
			return CalcTextSizeImpl(text, start);
		}

		public static Vector2 CalcTextSize(string text, float wrapWidth)
		{
			return CalcTextSizeImpl(text, wrapWidth: wrapWidth);
		}

		public static Vector2 CalcTextSize(string text, bool hideTextAfterDoubleHash)
		{
			return CalcTextSizeImpl(text, hideTextAfterDoubleHash: hideTextAfterDoubleHash);
		}

		public static Vector2 CalcTextSize(string text, int start, int length)
		{
			return CalcTextSizeImpl(text, start, length);
		}

		public static Vector2 CalcTextSize(string text, int start, bool hideTextAfterDoubleHash)
		{
			return CalcTextSizeImpl(text, start, hideTextAfterDoubleHash: hideTextAfterDoubleHash);
		}

		public static Vector2 CalcTextSize(string text, int start, float wrapWidth)
		{
			return CalcTextSizeImpl(text, start, wrapWidth: wrapWidth);
		}

		public static Vector2 CalcTextSize(string text, bool hideTextAfterDoubleHash, float wrapWidth)
		{
			return CalcTextSizeImpl(text, hideTextAfterDoubleHash: hideTextAfterDoubleHash, wrapWidth: wrapWidth);
		}

		public static Vector2 CalcTextSize(string text, int start, int length, bool hideTextAfterDoubleHash)
		{
			return CalcTextSizeImpl(text, start, length, hideTextAfterDoubleHash);
		}

		public static Vector2 CalcTextSize(string text, int start, int length, float wrapWidth)
		{
			return CalcTextSizeImpl(text, start, length, wrapWidth: wrapWidth);
		}

		public static Vector2 CalcTextSize(string text, int start, int length, bool hideTextAfterDoubleHash, float wrapWidth)
		{
			return CalcTextSizeImpl(text, start, length, hideTextAfterDoubleHash, wrapWidth);
		}

		private static Vector2 CalcTextSizeImpl(
			string text,
			int start = 0,
			int? length = null,
			bool hideTextAfterDoubleHash = false,
			float wrapWidth = -1.0f)
		{
			Vector2 ret;
			byte* nativeTextStart = null;
			byte* nativeTextEnd = null;
			var textByteCount = 0;
			if (text != null)
			{

				var textToCopyLen = length.HasValue ? length.Value : text.Length;
				textByteCount = Util.CalcSizeInUtf8(text, start, textToCopyLen);
				if (textByteCount > Util.StackAllocationSizeLimit)
				{
					nativeTextStart = Util.Allocate(textByteCount + 1);
				}
				else
				{
					var nativeTextStackBytes = stackalloc byte[textByteCount + 1];
					nativeTextStart = nativeTextStackBytes;
				}

				var nativeTextOffset = Util.GetUtf8(text, start, textToCopyLen, nativeTextStart, textByteCount);
				nativeTextStart[nativeTextOffset] = 0;
				nativeTextEnd = nativeTextStart + nativeTextOffset;
			}

			ImGuiNative.igCalcTextSize(&ret, nativeTextStart, nativeTextEnd, *((byte*)(&hideTextAfterDoubleHash)), wrapWidth);
			if (textByteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(nativeTextStart);
			}

			return ret;
		}

		public static bool InputText(
			ReadOnlySpan<char> label,
			IntPtr buf,
			uint buf_size)
		{
			return InputText(label, buf, buf_size, 0, null, IntPtr.Zero);
		}

		public static bool InputText(
			ReadOnlySpan<char> label,
			IntPtr buf,
			uint buf_size,
			ImGuiInputTextFlags flags)
		{
			return InputText(label, buf, buf_size, flags, null, IntPtr.Zero);
		}

		public static bool InputText(
			ReadOnlySpan<char> label,
			IntPtr buf,
			uint buf_size,
			ImGuiInputTextFlags flags,
			delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData*, int> callback)
		{
			return InputText(label, buf, buf_size, flags, callback, IntPtr.Zero);
		}

		public static bool InputText(
			ReadOnlySpan<char> label,
			IntPtr buf,
			uint buf_size,
			ImGuiInputTextFlags flags,
			delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData*, int> callback,
			IntPtr user_data)
		{
			var utf8LabelByteCount = Encoding.UTF8.GetByteCount(label);
			byte* utf8LabelBytes;
			if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
			{
				utf8LabelBytes = Util.Allocate(utf8LabelByteCount + 1);
			}
			else
			{
				var stackPtr = stackalloc byte[utf8LabelByteCount + 1];
				utf8LabelBytes = stackPtr;
			}
			Util.GetUtf8(label, utf8LabelBytes, utf8LabelByteCount);

			var ret = ImGuiNative.igInputText(utf8LabelBytes, (byte*)buf.ToPointer(), buf_size, flags, callback, user_data.ToPointer()) != 0;

			if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(utf8LabelBytes);
			}

			return ret;
		}

		public static bool Begin(ReadOnlySpan<char> name, ImGuiWindowFlags flags)
		{
			var utf8NameByteCount = Encoding.UTF8.GetByteCount(name);
			byte* utf8NameBytes;
			if (utf8NameByteCount > Util.StackAllocationSizeLimit)
			{
				utf8NameBytes = Util.Allocate(utf8NameByteCount + 1);
			}
			else
			{
				var stackPtr = stackalloc byte[utf8NameByteCount + 1];
				utf8NameBytes = stackPtr;
			}
			Util.GetUtf8(name, utf8NameBytes, utf8NameByteCount);

			byte* p_open = null;
			var ret = ImGuiNative.igBegin(utf8NameBytes, p_open, flags);

			if (utf8NameByteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(utf8NameBytes);
			}

			return ret != 0;
		}

		public static bool MenuItem(ReadOnlySpan<char> label, bool enabled)
		{
			return MenuItem(label, string.Empty, false, enabled);
		}
	}
}
