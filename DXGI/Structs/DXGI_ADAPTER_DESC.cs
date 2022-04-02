using DirectDimensional.Bindings.WinAPI;
using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.DXGI {
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DXGI_ADAPTER_DESC {
        /// <summary>
        /// 128 characters string
        /// </summary>
        public IntPtr Description;  
        public uint VendorId;
        public uint DeviceId;
        public uint SubSysId;
        public uint Revision;
        public nuint DedicatedVideoMemory;
        public nuint DedicatedSystemMemory;
        public nuint SharedSystemMemory;
        public LUID AdapterLuid;
    }
}
