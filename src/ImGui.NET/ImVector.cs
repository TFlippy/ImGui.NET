using System;
using System.Runtime.CompilerServices;

namespace ImGuiNET
{
	public unsafe struct ImVector
	{
		public readonly int Size;
		public readonly int Capacity;
		public readonly IntPtr Data;

		public ref T Ref<T>(int index)
		{
			return ref Unsafe.AsRef<T>((byte*)this.Data + index * Unsafe.SizeOf<T>());
		}

		public IntPtr Address<T>(int index)
		{
			return (IntPtr)((byte*)this.Data + index * Unsafe.SizeOf<T>());
		}
	}

	public unsafe struct ImVector<T>
	{
		public readonly int Size;
		public readonly int Capacity;
		public readonly IntPtr Data;

		public ImVector(ImVector vector)
		{
			this.Size = vector.Size;
			this.Capacity = vector.Capacity;
			this.Data = vector.Data;
		}

		public ImVector(int size, int capacity, IntPtr data)
		{
			this.Size = size;
			this.Capacity = capacity;
			this.Data = data;
		}

		public ref T this[int index] => ref Unsafe.AsRef<T>((byte*)this.Data + index * Unsafe.SizeOf<T>());
	}

	public unsafe struct ImPtrVector<T>
	{
		public readonly int Size;
		public readonly int Capacity;
		public readonly IntPtr Data;
		private readonly int _stride;

		public ImPtrVector(ImVector vector, int stride)
			: this(vector.Size, vector.Capacity, vector.Data, stride)
		{ }

		public ImPtrVector(int size, int capacity, IntPtr data, int stride)
		{
			this.Size = size;
			this.Capacity = capacity;
			this.Data = data;
			this._stride = stride;
		}

		public T this[int index]
		{
			get
			{
				var address = (byte*)this.Data + index * this._stride;
				var ret = Unsafe.Read<T>(&address);
				return ret;
			}
		}
	}
}
