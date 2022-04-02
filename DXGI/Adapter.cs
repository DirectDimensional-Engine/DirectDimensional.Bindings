using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.DXGI {
    [Guid("2411e7e1-12ac-4ccf-bd14-9798e8534dc0")]
    public sealed unsafe class Adapter : DXGIObject {
        public Adapter(IntPtr ptr) : base(ptr) { }

        public HRESULT GetDesc(out DXGI_ADAPTER_DESC description) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 8 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, DXGI_ADAPTER_DESC*, HRESULT>)(*(IntPtr*)address);

            fixed (DXGI_ADAPTER_DESC* pDesc = &description) {
                return @delegate(_nativePointer, pDesc);
            }
        }

        public HRESULT CheckInterfaceSupport(Guid guid, out long pUMDVersion) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 9 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, Guid, long*, HRESULT>)(*(IntPtr*)address);

            fixed (long* ptr = &pUMDVersion) {
                return @delegate(_nativePointer, guid, ptr);
            }
        }
    }
}
