using System;
using System.Numerics;
using System.Text;

namespace ImGuiNET
{
	public unsafe partial struct ImDrawListPtr
	{
		public void AddText(Vector2 pos, uint col, ReadOnlySpan<char> text_begin)
		{
			var native_text_begin = default(byte*);
			var native_text_end = default(byte*);
			var byte_count = 0;

			if (!text_begin.IsEmpty)
			{
				byte_count = Util.CalcSizeInUtf8(text_begin, 0, text_begin.Length);
				if (byte_count > Util.StackAllocationSizeLimit)
				{
					native_text_begin = Util.Allocate(byte_count + 1);
				}
				else
				{
					var buffer = stackalloc byte[byte_count + 1];
					native_text_begin = buffer;
				}

				var offset = Util.GetUtf8(text_begin, native_text_begin, byte_count);
				
				native_text_end = &native_text_begin[offset];
				*native_text_end = 0;
			}
			else
			{
				var buffer = stackalloc byte[1];
				native_text_begin = buffer;
			}

	
			//var text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
			//var native_text_begin = stackalloc byte[text_begin_byteCount + 1];
			//fixed (char* text_begin_ptr = text_begin)
			//{
			//	var native_text_begin_offset = Encoding.UTF8.GetBytes(text_begin_ptr, text_begin.Length, native_text_begin, text_begin_byteCount);
			//	native_text_begin[native_text_begin_offset] = 0;
			//}
			//byte* native_text_end = null;
			//ImGuiNative.ImDrawList_AddTextVec2(this.NativePtr, pos, col, native_text_begin, native_text_end);
			ImGuiNative.ImDrawList_AddTextVec2(this.NativePtr, pos, col, native_text_begin, native_text_end);

			if (byte_count > Util.StackAllocationSizeLimit) Util.Free(native_text_begin);
		}

		public void AddText(ImFontPtr font, float font_size, Vector2 pos, uint col, ReadOnlySpan<char> text_begin)
		{
			var native_text_begin = default(byte*);
			var native_text_end = default(byte*);
			var byte_count = 0;

			var native_font = font.NativePtr;
			var wrap_width = 0.0f;
			var cpu_fine_clip_rect = default(Vector4*);

			if (!text_begin.IsEmpty)
			{
				byte_count = Util.CalcSizeInUtf8(text_begin, 0, text_begin.Length);
				if (byte_count > Util.StackAllocationSizeLimit)
				{
					native_text_begin = Util.Allocate(byte_count + 1);
				}
				else
				{
					var buffer = stackalloc byte[byte_count + 1];
					native_text_begin = buffer;
				}

				var offset = Util.GetUtf8(text_begin, native_text_begin, byte_count);

				native_text_end = &native_text_begin[offset];
				*native_text_end = 0;
			}
			else
			{
				var buffer = stackalloc byte[1];
				native_text_begin = buffer;
			}

			ImGuiNative.ImDrawList_AddTextFontPtr(this.NativePtr, native_font, font_size, pos, col, native_text_begin, native_text_end, wrap_width, cpu_fine_clip_rect);

			if (byte_count > Util.StackAllocationSizeLimit) Util.Free(native_text_begin);

			//var native_font = font.NativePtr;
			//var text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
			//var native_text_begin = stackalloc byte[text_begin_byteCount + 1];
			//fixed (char* text_begin_ptr = text_begin)
			//{
			//	var native_text_begin_offset = Encoding.UTF8.GetBytes(text_begin_ptr, text_begin.Length, native_text_begin, text_begin_byteCount);
			//	native_text_begin[native_text_begin_offset] = 0;
			//}
			//byte* native_text_end = null;
			//var wrap_width = 0.0f;
			//Vector4* cpu_fine_clip_rect = null;
			//ImGuiNative.ImDrawList_AddTextFontPtr(this.NativePtr, native_font, font_size, pos, col, native_text_begin, native_text_end, wrap_width, cpu_fine_clip_rect);
		}
	}
}
