using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    [Guid("da6fea51-564c-4487-9810-f0d0f9b4e3a5")]
    public sealed unsafe class SamplerState : DeviceChild {
        public SamplerState(IntPtr ptr) : base(ptr) {
        }

        public D3D11_SAMPLER_DESC Description {
            get {
                IntPtr address = (*(IntPtr*)_nativePointer) + 8 * IntPtr.Size;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_SAMPLER_DESC*, void>)(*(IntPtr*)address);

                D3D11_SAMPLER_DESC desc;
                @delegate(_nativePointer, &desc);

                return desc;
            }
        }
    }
}
