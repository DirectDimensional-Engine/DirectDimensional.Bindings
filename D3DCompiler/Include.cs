using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.D3DCompiler {
    public abstract unsafe class Include : IDisposable {
        [UnmanagedFunctionPointer(CallingConvention.Winapi, CharSet = CharSet.Ansi)]
        private delegate HRESULT OpenCallback(IntPtr pThis, D3D_INCLUDE_TYPE includeType, string fileName, IntPtr pParentData, IntPtr ppData, IntPtr pBytes);
        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        private delegate HRESULT CloseCallback(IntPtr pThis, IntPtr pData);

        protected bool disposed;
        internal readonly IntPtr VirtualTable;

        // Need to keep reference to these callback because once, the process terminated because the callback function pointer were garbage collected for some reason
        private OpenCallback _openCallback;
        private CloseCallback _closeCallback;

        public Include() {
            VirtualTable = Marshal.AllocHGlobal(IntPtr.Size * 3);
            Marshal.WriteIntPtr(VirtualTable, VirtualTable + IntPtr.Size);

            // Can't do this anymore as the callback might be garbage collected. Better keep the reference to the callback like the Document stated
            // Marshal.WriteIntPtr(VirtualTable + IntPtr.Size, Marshal.GetFunctionPointerForDelegate<OpenCallback>(OpenWrapper));
            // Marshal.WriteIntPtr(VirtualTable + IntPtr.Size * 2, Marshal.GetFunctionPointerForDelegate<CloseCallback>(CloseWrapper));

            _openCallback = new(OpenWrapper);
            _closeCallback = new(CloseWrapper);

            Marshal.WriteIntPtr(VirtualTable, IntPtr.Size, Marshal.GetFunctionPointerForDelegate(_openCallback));
            Marshal.WriteIntPtr(VirtualTable, IntPtr.Size * 2, Marshal.GetFunctionPointerForDelegate(_closeCallback));
        }

        private HRESULT OpenWrapper(IntPtr pThis, D3D_INCLUDE_TYPE includeType, string fileName, IntPtr pParentData, IntPtr ppData, IntPtr pBytes) {
            return Open(includeType, fileName, pParentData, ppData, pBytes);
        }
        private HRESULT CloseWrapper(IntPtr pThis, IntPtr pData) {
            return Close(pData);
        }

        ~Include() {
            Dispose(disposing: false);
        }
        protected virtual void Dispose(bool disposing) {
            if (!disposed) {
                if (disposing) {
                }

                Marshal.FreeHGlobal(VirtualTable);
                disposed = true;
            }
        }
        public void Dispose() {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public abstract HRESULT Open(D3D_INCLUDE_TYPE includeType, string pFileName, IntPtr pParentData, IntPtr ppData, IntPtr pBytes);
        public abstract HRESULT Close(IntPtr pData);
    }
}
