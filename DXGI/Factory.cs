using System.Runtime.InteropServices;
using D3DDevice = DirectDimensional.Bindings.Direct3D11.Device;

namespace DirectDimensional.Bindings.DXGI {
    [Guid("7b7166ec-21c7-44ae-b21a-c9ae321ae369")]
    public sealed unsafe class Factory : DXGIObject {
        public Factory(IntPtr ptr) : base(ptr) {
        }

        public HRESULT EnumAdapters(uint adapterIndex, out Adapter? outputAdapter) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 7 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, void**, HRESULT>)(*(IntPtr*)address);

            void* pAdapter;
            HRESULT hr = @delegate(_nativePointer, adapterIndex, &pAdapter);
            if (hr.Failed) {
                outputAdapter = null;

                return hr;
            }

            outputAdapter = new(new IntPtr(pAdapter));
            return hr;
        }

        /// <summary>
        /// See <a href="https://docs.microsoft.com/en-us/windows/win32/api/dxgi/nf-dxgi-idxgifactory-makewindowassociation">this</a> for more information
        /// </summary>
        public HRESULT MakeWindowAssociation(IntPtr hwnd, uint flags) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 8 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, uint, HRESULT>)(*(IntPtr*)address);

            return @delegate(_nativePointer, hwnd, flags);
        }

        public HRESULT GetWindowAssociation(out IntPtr hwnd) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 9 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, void**, HRESULT>)(*(IntPtr*)address);

            void* outhwnd;
            HRESULT hr = @delegate(_nativePointer, &outhwnd);

            hwnd = new(outhwnd);
            return hr;
        }

        public HRESULT CreateSwapChain(D3DDevice pDevice, in DXGI_SWAP_CHAIN_DESC desc, out SwapChain? output) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 10 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, DXGI_SWAP_CHAIN_DESC*, void**, HRESULT>)(*(IntPtr*)address);

            fixed (DXGI_SWAP_CHAIN_DESC* pDesc = &desc) {
                void* pSwapChain;
                HRESULT hr = @delegate(_nativePointer, pDevice._nativePointer, pDesc, &pSwapChain);
                if (hr.Failed) {
                    output = null;
                    return hr;
                }

                output = new(new IntPtr(pSwapChain));
                return hr;
            }
        }
    }
}
