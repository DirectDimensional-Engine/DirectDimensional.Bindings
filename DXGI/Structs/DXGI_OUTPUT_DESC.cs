using System;
using System.Runtime.InteropServices;
using DirectDimensional.Bindings.WinAPI;

namespace DirectDimensional.Bindings.DXGI {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DXGI_OUTPUT_DESC {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;
        public RECT DesktopCoordinates;
        [MarshalAs(UnmanagedType.Bool)]
        public bool AttachToDesktop;
        public DXGI_MODE_ROTATION Rotation;
        public IntPtr Monitor;
    }
}
