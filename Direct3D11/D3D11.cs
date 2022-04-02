using System.Runtime.InteropServices;
using DirectDimensional.Bindings.DXGI;

namespace DirectDimensional.Bindings.Direct3D11 {
    internal static unsafe class D3D11 {
        public static HRESULT CreateDevice(D3D_DRIVER_TYPE driverType, IntPtr hSoftware, D3D11_CREATE_DEVICE_FLAG flags, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] D3D_FEATURE_LEVEL[]? featureLevels, out Device? outDevice, out D3D_FEATURE_LEVEL useFeatureLevel, out DeviceContext? outDevCon) {
            HRESULT hr = D3D11CreateDevice(IntPtr.Zero, driverType, IntPtr.Zero, flags, featureLevels, featureLevels == null ? 0u : (uint)featureLevels.Length, 7, out var ppDevice, out useFeatureLevel, out var ppDevCon);
            if (hr.Failed) {
                outDevice = null;
                useFeatureLevel = D3D_FEATURE_LEVEL.Unknown;
                outDevCon = null;

                return hr;
            }

            outDevice = new(ppDevice);
            outDevCon = new(ppDevCon);

            return hr;
        }

        public static HRESULT CreateDeviceAndSwapChain(D3D_DRIVER_TYPE driverType, IntPtr hSoftware, D3D11_CREATE_DEVICE_FLAG flags, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] D3D_FEATURE_LEVEL[]? featureLevels, in DXGI_SWAP_CHAIN_DESC swapChainDesc, out SwapChain? outSwapChain, out Device? outDevice, out D3D_FEATURE_LEVEL useFeatureLevel, out DeviceContext? outDevCon) {
            fixed (DXGI_SWAP_CHAIN_DESC* pDesc = &swapChainDesc) {
                HRESULT hr = D3D11CreateDeviceAndSwapChain(IntPtr.Zero, driverType, hSoftware, flags, featureLevels, featureLevels == null ? 0u : (uint)featureLevels.Length, 7, pDesc, out IntPtr ppSwapChain, out IntPtr ppDevice, out useFeatureLevel, out IntPtr ppDevCon);
                if (hr.Failed) {
                    outDevCon = null;
                    outDevice = null;
                    useFeatureLevel = D3D_FEATURE_LEVEL.Unknown;
                    outSwapChain = null;

                    return hr;
                }

                outDevice = new(ppDevice);
                outDevCon = new(ppDevCon);
                outSwapChain = new(ppSwapChain);

                return hr;
            }
        }

        [DllImport("d3d11.dll", ExactSpelling = true)]
        private static extern HRESULT D3D11CreateDevice(IntPtr pAdapter, D3D_DRIVER_TYPE driverType, IntPtr hSoftware, D3D11_CREATE_DEVICE_FLAG flags, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] D3D_FEATURE_LEVEL[]? featureLevels, uint numFeatureLevels, uint sdkVersion, out IntPtr ppDevice, out D3D_FEATURE_LEVEL useFeatureLevel, out IntPtr ppDevCon);
        [DllImport("d3d11.dll", ExactSpelling = true)]
        private static extern HRESULT D3D11CreateDeviceAndSwapChain(IntPtr pAdapter, D3D_DRIVER_TYPE driverType, IntPtr hSoftware, D3D11_CREATE_DEVICE_FLAG flags, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] D3D_FEATURE_LEVEL[]? featureLevels, uint numFeatureLevels, uint sdkVersion, DXGI_SWAP_CHAIN_DESC* swapChainDesc, out IntPtr ppSwapChain, out IntPtr ppDevice, out D3D_FEATURE_LEVEL useFeatureLevel, out IntPtr ppDevCon);
    }
}
