namespace DirectDimensional.Bindings.WinAPI {
    internal struct RAWINPUTDEVICE {
        public ushort UsagePage;
        public ushort Usage;
        public uint Flags;
        public IntPtr hwndTarget;
    }
}
