namespace DirectDimensional.Bindings.WinAPI {
    internal struct RAWHID {
        public uint SizeHid;
        public uint Count;
        public unsafe fixed byte RawData[1];
    }
}
