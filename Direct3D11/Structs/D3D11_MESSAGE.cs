using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    public unsafe struct D3D11_MESSAGE : IDisposable {
        public D3D11_MESSAGE_CATEGORY Category;
        public D3D11_MESSAGE_SEVERITY Severity;
        public D3D11_MESSAGE_ID ID;
        private IntPtr pDescription;
        public nuint DescriptionByteLength;

        public string Description => Marshal.PtrToStringAnsi(pDescription)!;

        public static D3D11_MESSAGE Allocate(int messageSize) {
            D3D11_MESSAGE msg = default;

            msg.pDescription = Marshal.AllocHGlobal(messageSize - sizeof(nuint) - 12);

            return msg;
        }

        public void Dispose() {
            if (pDescription != IntPtr.Zero) Marshal.FreeHGlobal(pDescription);
        }
    }
}
