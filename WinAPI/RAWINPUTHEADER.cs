namespace DirectDimensional.Bindings.WinAPI {
    internal struct RAWINPUTHEADER {
        public uint Type;
        public uint Size;
        public IntPtr Handle;
        public nuint wParam;
    }
}
