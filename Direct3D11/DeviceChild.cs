using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    [Guid("1841e5c8-16b0-489b-bcc8-44cfb0d5deae")]
    public unsafe abstract class DeviceChild : ComObject {
        public DeviceChild(IntPtr ptr) : base(ptr) { }

        public void GetDevice(out Device device) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 3 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, void**, void>)(*(IntPtr*)address);

            void* pDevice;
            @delegate(_nativePointer, &pDevice);

            device = new Device(new IntPtr(pDevice));
        }

        public HRESULT GetPrivateData(Guid guid, ref uint pDataSize, IntPtr pData) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 4 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, Guid, ref uint, IntPtr, HRESULT>)(*(IntPtr*)address);

            return @delegate(_nativePointer, guid, ref pDataSize, pData);
        }

        public HRESULT SetPrivateData(Guid guid, uint pDataSize, IntPtr pData) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 5 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, Guid, uint, IntPtr, HRESULT>)(*(IntPtr*)address);

            return @delegate(_nativePointer, guid, pDataSize, pData);
        }

        public HRESULT SetPrivateDataInterface(Guid guid, ComObject? pData) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 6 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, Guid, IntPtr, HRESULT>)(*(IntPtr*)address);

            return @delegate(_nativePointer, guid, pData.GetNativePtr());
        }
    }
}
