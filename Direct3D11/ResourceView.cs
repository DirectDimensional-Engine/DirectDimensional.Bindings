using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.Direct3D11 {
    [Guid("839d1216-bb2e-412b-b7f4-a9dbebe08ed1")]
    public abstract unsafe class ResourceView : DeviceChild {
        public ResourceView(IntPtr ptr) : base(ptr) { }

        public Resource Resource {
            get {
                IntPtr address = (*(IntPtr*)_nativePointer) + 7 * IntPtr.Size;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, void**, void>)(*(IntPtr*)address);

                void* pResource;
                @delegate(_nativePointer, &pResource);

                return new Resource(new IntPtr(pResource));
            }
        }
    }
}
