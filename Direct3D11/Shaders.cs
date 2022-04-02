using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    [Guid("3b301d64-d678-4289-8897-22f8928b72f3")]
    public sealed class VertexShader : DeviceChild {
        public VertexShader(IntPtr ptr) : base(ptr) { }
    }

    [Guid("ea82e40d-51dc-4f33-93d4-db7c9125ae8c")]
    public sealed class PixelShader : DeviceChild {
        public PixelShader(IntPtr ptr) : base(ptr) { }
    }
}
