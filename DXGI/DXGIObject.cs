using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.DXGI {
    [Guid("aec22fb8-76f3-4639-9be0-28eb43a67a2e")]
    public unsafe abstract class DXGIObject : ComObject {
        public DXGIObject(IntPtr ptr) : base(ptr) { }

        public HRESULT SetPrivateData(Guid guid, uint size, IntPtr pInput) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 3 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, Guid, uint, IntPtr, HRESULT>)(*(IntPtr*)address);

            return @delegate(_nativePointer, guid, size, pInput);
        }

        public HRESULT SetPrivateDataInterface(Guid guid, ComObject iunknown) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 4 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, Guid, IntPtr, HRESULT>)(*(IntPtr*)address);

            return @delegate(_nativePointer, guid, iunknown.GetNativePtr());
        }

        public HRESULT GetPrivateData(Guid guid, ref uint size, IntPtr pOutput) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 5 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, Guid, ref uint, IntPtr, HRESULT>)(*(IntPtr*)address);

            return @delegate(_nativePointer, guid, ref size, pOutput);
        }

        public HRESULT GetParent(Guid guid, out IntPtr parent) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 6 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, Guid, void**, HRESULT>)(*(IntPtr*)address);

            void* pParent;
            HRESULT hr = @delegate(_nativePointer, guid, &pParent);
            parent = new IntPtr(pParent);
            return hr;
        }

        public T? GetParent<T>(out HRESULT hr) where T : ComObject {
            IntPtr address = (*(IntPtr*)_nativePointer) + 6 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, Guid, void**, HRESULT>)(*(IntPtr*)address);

            var type = typeof(T);

            void* pParent;
            hr = @delegate(_nativePointer, type.GUID, &pParent);

            return Activator.CreateInstance(type, new IntPtr(pParent)) as T;
        }
    }
}
