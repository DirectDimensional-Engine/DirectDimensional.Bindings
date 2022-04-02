using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    [Guid("dc8e63f3-d12b-4952-b47b-5e45026a862d")]
    public unsafe class Resource : DeviceChild {
        public Resource(IntPtr ptr) : base(ptr) { }

        public D3D11_RESOURCE_DIMENSION Type {
            get {
                IntPtr address = (*(IntPtr*)_nativePointer) + 7 * IntPtr.Size;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_RESOURCE_DIMENSION*, void>)(*(IntPtr*)address);

                D3D11_RESOURCE_DIMENSION output = D3D11_RESOURCE_DIMENSION.Unknown;
                @delegate(_nativePointer, &output);

                return output;
            }
        }
        public uint EvictionPriority {
            get {
                IntPtr address = (*(IntPtr*)_nativePointer) + 9 * IntPtr.Size;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint>)(*(IntPtr*)address);

                return @delegate(_nativePointer);
            }

            set {
                IntPtr address = (*(IntPtr*)_nativePointer) + 8 * IntPtr.Size;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, void>)(*(IntPtr*)address);

                @delegate(_nativePointer, value);
            }
        }
    }
}
