using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.DXGI {
    public struct DXGI_SWAP_CHAIN_DESC {
        public DXGI_MODE_DESC BufferDesc;
        public DXGI_SAMPLE_DESC SampleDesc;
        public DXGI_USAGE BufferUsage;
        public uint BufferCount;
        public IntPtr OutputWindow;
        [MarshalAs(UnmanagedType.Bool)]
        public bool Windowed;
        public DXGI_SWAP_EFFECT SwapEffect;
        public DXGI_SWAP_CHAIN_FLAG Flags;
    }
}
