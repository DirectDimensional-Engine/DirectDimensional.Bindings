using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using DirectDimensional.Bindings.WinAPI;

namespace DirectDimensional.Bindings {
    /// <summary>
    /// A wrapper for IntPtr created from Marshal.AllocHGlobal that can free the pointer on GC collect
    /// </summary>
    public sealed unsafe class MemoryHolder : IDisposable {
        private IntPtr _pointer;
        private int _size;
        public IntPtr Underlying => _pointer;
        public int Size => _size;

        private MemoryHolder() { }

        ~MemoryHolder() {
            Dispose();
        }

        public void Dispose() {
            var pointer = Interlocked.Exchange(ref _pointer, IntPtr.Zero);
            if (pointer != IntPtr.Zero) {
                Marshal.FreeHGlobal(pointer);
                GC.SuppressFinalize(this);
            }
        }

        public void Resize(nint newSize) {
            if (_size == newSize) return;
            if (newSize <= 0) throw new ArgumentOutOfRangeException(nameof(newSize));

            _pointer = Marshal.ReAllocHGlobal(_pointer, newSize);
        }

        public void Write<T>(in T input, int offset, uint size) where T : unmanaged {
            fixed (T* pInput = &input) {
                Unsafe.CopyBlock((_pointer + offset).ToPointer(), pInput, size);
            }
        }

        public void Write<T>(in T input, int offset) where T : unmanaged {
            fixed (T* pInput = &input) {
                Unsafe.CopyBlock((_pointer + offset).ToPointer(), pInput, (uint)sizeof(T));
            }
        }

        public static MemoryHolder AllocMemory(int size, byte init = 0) {
            IntPtr memory = Marshal.AllocHGlobal(size);
            Unsafe.InitBlock(memory.ToPointer(), init, (uint)size);

            return new MemoryHolder() { _pointer = memory, _size = size };
        }

        public static MemoryHolder AllocMemory<T>(byte init = 0) {
            int s = Marshal.SizeOf<T>();
            IntPtr memory = Marshal.AllocHGlobal(s);
            Unsafe.InitBlock(memory.ToPointer(), init, (uint)s);

            return new MemoryHolder() { _pointer = memory, _size = s };
        }

        public T ToStructure<T>() where T : unmanaged {
            return Marshal.PtrToStructure<T>(_pointer);
        }

        public ref T ToStructureRef<T>() where T : unmanaged {
            return ref Unsafe.AsRef<T>(_pointer.ToPointer());
        }

        public ref T As<T>() {
            return ref Unsafe.AsRef<T>(_pointer.ToPointer());
        }
    }
}
