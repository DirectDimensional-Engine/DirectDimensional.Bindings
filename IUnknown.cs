using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings {
    [Guid("00000000-0000-0000-C000-000000000046")]
    public interface IUnknown {
        HRESULT QueryInterface(Guid riid, out IntPtr ppOut);
        uint AddRef();
        uint Release();
    }
}
