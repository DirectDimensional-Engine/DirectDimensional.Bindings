using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    [Guid("75b68faa-347d-4159-8f45-a0640f01cd9a")]
    public sealed unsafe class BlendState : DeviceChild {
        public BlendState(IntPtr ptr) : base(ptr) { }

        public D3D11_BLEND_DESC Description {
            get {
                IntPtr address = (*(IntPtr*)_nativePointer) + 7 * IntPtr.Size;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_BLEND_DESC*, void>)(*(IntPtr*)address);

                D3D11_BLEND_DESC desc;
                @delegate(_nativePointer, &desc);

                return desc;
            }
        }
    }
}
