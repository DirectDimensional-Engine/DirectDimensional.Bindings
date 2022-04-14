using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    [Guid("6543dbb6-1b48-42f5-ab82-e97ec74326f6")]
    public sealed unsafe class ID3D11InfoQueue : ComObject {
        public ID3D11InfoQueue(IntPtr ptr) : base(ptr) { }

        public void ClearStoredMessages() {
            IntPtr address = (*(IntPtr*)_nativePointer) + 4 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, void>)(*(IntPtr*)address);

            @delegate(_nativePointer);
        }

        public HRESULT GetMessage(ulong messageIndex, D3D11_MESSAGE* pMessage, ref nuint messageByteLength) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 5 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, ulong, D3D11_MESSAGE*, nuint*, HRESULT>)(*(IntPtr*)address);

            fixed (nuint* pMessageByteLength = &messageByteLength) {
                return @delegate(_nativePointer, messageIndex, pMessage, pMessageByteLength);
            }
        }

        public ulong GetNumStoredMessages() {
            IntPtr address = (*(IntPtr*)_nativePointer) + 8 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, ulong>)(*(IntPtr*)address);

            return @delegate(_nativePointer);
        }

        public HRESULT PushEmptyStorageFilter() {
            IntPtr address = (*(IntPtr*)_nativePointer) + 15 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, HRESULT>)(*(IntPtr*)address);

            return @delegate(_nativePointer);
        }
    }
}
