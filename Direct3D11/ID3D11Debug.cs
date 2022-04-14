using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    [Guid("79cf2233-7536-4948-9d36-1e4692dc5760")]
    public sealed unsafe class ID3D11Debug : ComObject {
        public ID3D11Debug(IntPtr ptr) : base(ptr) { }

        public HRESULT SetFeatureMask(uint mask) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 3 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, HRESULT>)(*(IntPtr*)address);

            return @delegate(_nativePointer, mask);
        }

        public uint GetFeatureMask() {
            IntPtr address = (*(IntPtr*)_nativePointer) + 4 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint>)(*(IntPtr*)address);

            return @delegate(_nativePointer);
        }

        public HRESULT ReportLiveDeviceObjects(D3D11_RLDO_FLAGS flags) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 10 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_RLDO_FLAGS, HRESULT>)(*(IntPtr*)address);

            return @delegate(_nativePointer, flags);
        }
    }
}
