using System.Runtime.InteropServices;
using D3DDevice = DirectDimensional.Bindings.Direct3D11.Device;
using DXGIDevice = DirectDimensional.Bindings.DXGI.Device;
using DirectDimensional.Bindings.Direct3D11;

namespace DirectDimensional.Bindings.DXGI {
    [Guid("310d36a0-d2e7-4c0a-aa04-6a9d23b8886a")]
    public sealed unsafe class SwapChain : DeviceSubObject {
        public SwapChain(IntPtr ptr) : base(ptr) { }

        public HRESULT Present(uint syncInternal, DXGI_PRESENT flags) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 8 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, DXGI_PRESENT, HRESULT>)(*(IntPtr*)address);

            return @delegate(_nativePointer, syncInternal, flags);
        }

        public HRESULT GetBuffer<T>(uint buffer, out T? output) where T : Resource {
            IntPtr address = (*(IntPtr*)_nativePointer) + 9 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, Guid, void**, HRESULT>)(*(IntPtr*)address);

            void* pBuffer;
            HRESULT hr = @delegate(_nativePointer, buffer, typeof(T).GUID, &pBuffer);
            if (hr.Failed) {
                output = default;
                return hr;
            }

            output = Activator.CreateInstance(typeof(T), new IntPtr(pBuffer)) as T;
            return hr;
        }

        public HRESULT GetDesc(out DXGI_SWAP_CHAIN_DESC description) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 12 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, DXGI_SWAP_CHAIN_DESC*, HRESULT>)(*(IntPtr*)address);

            fixed (DXGI_SWAP_CHAIN_DESC* pDesc = &description) {
                return @delegate(_nativePointer, pDesc);
            }
        }

        public HRESULT ResizeBuffer(uint bufferCount, uint width, uint height, DXGI_FORMAT newFormat, DXGI_SWAP_CHAIN_FLAG flags) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 13 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, uint, uint, DXGI_FORMAT, DXGI_SWAP_CHAIN_FLAG, HRESULT>)(*(IntPtr*)address);

            return @delegate(_nativePointer, bufferCount, width, height, newFormat, flags);
        }

        public HRESULT ResizeTarget(in DXGI_MODE_DESC description) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 14 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, DXGI_MODE_DESC*, HRESULT>)(*(IntPtr*)address);

            fixed (DXGI_MODE_DESC* pDesc = &description) {
                return @delegate(_nativePointer, pDesc);
            }
        }

        public HRESULT GetFrameStatistics(out DXGI_FRAME_STATISTICS statistic) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 16 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, DXGI_FRAME_STATISTICS*, HRESULT>)(*(IntPtr*)address);

            fixed (DXGI_FRAME_STATISTICS* pStatistic = &statistic) {
                return @delegate(_nativePointer, pStatistic);
            }
        }

        public HRESULT GetLastPresentCount(out uint lastPresentCount) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 17 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint*, HRESULT>)(*(IntPtr*)address);

            fixed (uint* pCount = &lastPresentCount) {
                return @delegate(_nativePointer, pCount);
            }
        }
    }
}
