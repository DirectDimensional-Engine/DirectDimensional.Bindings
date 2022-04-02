using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.DXGI {
    [Guid("54ec77fa-1377-44e6-8c32-88fd5f44c84c")]
    public sealed unsafe class Device : DXGIObject {
        public Device(IntPtr ptr) : base(ptr) { }

        public HRESULT GetAdapter(out Adapter? output) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 7 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, void**, HRESULT>)(*(IntPtr*)address);

            void* pAdapter;
            HRESULT hr = @delegate(_nativePointer, &pAdapter);
            if (hr.Failed) {
                output = null;
                return hr;
            }

            output = new Adapter(new IntPtr(pAdapter));
            return hr;
        }

        public int GPUThreadPriority {
            get {
                IntPtr address = (*(IntPtr*)_nativePointer) + 11 * IntPtr.Size;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int*, HRESULT>)(*(IntPtr*)address);

                // HRESULT is either S_OK, or E_POINTER if the integer pointer is null
                int value;
                @delegate(_nativePointer, &value);

                return value;
            }

            set {
                IntPtr address = (*(IntPtr*)_nativePointer) + 10 * IntPtr.Size;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, int, HRESULT>)(*(IntPtr*)address);

                // HRESULT is either S_OK, or S_INVALIDARG when value is not in [-7, 7]
                @delegate(_nativePointer, Math.Clamp(value, -7, 7));
            }
        }
    }
}
