using System;
using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.WinAPI {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct WNDCLASSEXW {
        public uint cbSize;
        public uint style;
        public WndProc lpfnWndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        public IntPtr hInstance;
        public IntPtr hIcon;
        public IntPtr hCursor;
        public IntPtr hbrBackground;

        public string lpszMenuName;
        public string lpszClassName;
        public IntPtr hIconSm;
    }
}
