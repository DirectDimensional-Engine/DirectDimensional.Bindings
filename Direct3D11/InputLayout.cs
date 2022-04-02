using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    [Guid("e4819ddc-4cf0-4025-bd26-5de82a3e07b7")]
    public sealed unsafe class InputLayout : DeviceChild {
        public InputLayout(IntPtr ptr) : base(ptr) { }
    }
}
