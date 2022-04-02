using System;
using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.DXGI {
    public struct DXGI_GAMMA_CONTROL_CAPABILITIES {
        [MarshalAs(UnmanagedType.Bool)]
        public bool ScaleAndOffsetSupported;
        public float MaxConvertedValue;
        public float MinConvertedValue;
        public uint NumGammaControlPoints;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1025)]
        public float[] ControlPointPositions;
    }
}
