using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.D3DCompiler {
    [Guid("EB62D63D-93DD-4318-8AE8-C6F83AD371B8")]
    public sealed unsafe class ShaderReflectionConstantBuffer : NativeObject {
        public ShaderReflectionConstantBuffer(IntPtr ptr) : base(ptr) { }

        public D3D11_SHADER_BUFFER_DESC Description {
            get {
                IntPtr address = *(IntPtr*)_nativePointer;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_SHADER_BUFFER_DESC*, HRESULT>)(*(IntPtr*)address);

                D3D11_SHADER_BUFFER_DESC desc;
                @delegate(_nativePointer, &desc);
                return desc;
            }
        }

        protected override void DisposeImpl() {
            throw new NotImplementedException("Cannot dispose Reflection members as it will be cleaned up when Release reflector.");
        }
    }
}
