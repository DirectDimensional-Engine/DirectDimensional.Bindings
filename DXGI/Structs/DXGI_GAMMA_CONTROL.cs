using System;
using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.DXGI {
    public struct DXGI_GAMMA_CONTROL {
        public DXGI_RGB Scale;
        public DXGI_RGB Offset;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1025)]
        public DXGI_RGB[] GammaCurve;
    }
}
