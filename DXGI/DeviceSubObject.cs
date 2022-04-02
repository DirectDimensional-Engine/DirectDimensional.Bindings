using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.DXGI {
    [Guid("3d3e0379-f9de-4d58-bb6c-18d62992f1a6")]
    public abstract unsafe class DeviceSubObject : DXGIObject {
        public DeviceSubObject(IntPtr ptr) : base(ptr) { }

        public HRESULT GetDevice(Guid guid, out IntPtr ppDevice) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 7 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, Guid, void**, HRESULT>)(*(IntPtr*)address);

            void* pParent;
            HRESULT hr = @delegate(_nativePointer, guid, &pParent);
            ppDevice = new IntPtr(pParent);
            return hr;
        }
    }
}
