﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace ImGuiNET
{
	internal static unsafe class Util
	{
		internal const int StackAllocationSizeLimit = 2048;

		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static string StringFromPtr(byte* ptr)
		{
			int characters = 0;
			while (ptr[characters] != 0)
			{
				characters++;
			}

			return Encoding.UTF8.GetString(ptr, characters);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal static bool AreStringsEqual(byte* a, int aLength, byte* b)
		{
			for (int i = 0; i < aLength; i++)
			{
				if (a[i] != b[i]) return false;
			}

			if (b[aLength] != 0) return false;

			return true;
		}

		internal static byte* Allocate(int byteCount) => (byte*)Marshal.AllocHGlobal(byteCount);

		internal static void Free(byte* ptr) => Marshal.FreeHGlobal((IntPtr)ptr);

		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal static int CalcSizeInUtf8(string s, int start, int length)
		{
			if (start < 0 || length < 0 || start + length > s.Length)
			{
				throw new ArgumentOutOfRangeException();
			}

			return Encoding.UTF8.GetByteCount(s.AsSpan().Slice(start, length));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal static int GetUtf8(ReadOnlySpan<char> s, byte* utf8Bytes, int utf8ByteCount)
		{
			return Encoding.UTF8.GetBytes(s, new Span<byte>(utf8Bytes, utf8ByteCount));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal static int GetUtf8(string s, byte* utf8Bytes, int utf8ByteCount)
		{
			return Encoding.UTF8.GetBytes(s.AsSpan(), new Span<byte>(utf8Bytes, utf8ByteCount));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal static int GetUtf8(ReadOnlySpan<char> s, int start, int length, byte* utf8Bytes, int utf8ByteCount)
		{
			if (start < 0 || length < 0 || start + length > s.Length)
			{
				throw new ArgumentOutOfRangeException();
			}

			return Encoding.UTF8.GetBytes(s.Slice(start, length), new Span<byte>(utf8Bytes, utf8ByteCount));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		internal static int GetUtf8(string s, int start, int length, byte* utf8Bytes, int utf8ByteCount)
		{
			if (start < 0 || length < 0 || start + length > s.Length)
			{
				throw new ArgumentOutOfRangeException();
			}

			return Encoding.UTF8.GetBytes(s.AsSpan().Slice(start, length), new Span<byte>(utf8Bytes, utf8ByteCount));
		}
	}
}
