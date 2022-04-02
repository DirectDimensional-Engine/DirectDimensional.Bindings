using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    [Guid("48570b85-d1ee-4fcd-a250-eb350722b037")]
    public unsafe sealed class Buffer : Resource {
        public Buffer(IntPtr ptr) : base(ptr) { }

        public D3D11_BUFFER_DESC Description {
            get {
                IntPtr address = (*(IntPtr*)_nativePointer) + 10 * IntPtr.Size;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_BUFFER_DESC*, void>)(*(IntPtr*)address);

                D3D11_BUFFER_DESC desc;
                @delegate(_nativePointer, &desc);

                return desc;
            }
        }
    }
}
