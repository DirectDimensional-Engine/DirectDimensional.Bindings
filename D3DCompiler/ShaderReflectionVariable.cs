using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.D3DCompiler {
    [Guid("51F23923-F3E5-4BD1-91CB-606177D8DB4C")]
    public sealed unsafe class ShaderReflectionVariable : NativeObject {
        public ShaderReflectionVariable(IntPtr ptr) : base(ptr) { }

        public D3D11_SHADER_VARIABLE_DESC Description {
            get {
                IntPtr address = *(IntPtr*)_nativePointer;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_SHADER_VARIABLE_DESC*, HRESULT>)(*(IntPtr*)address);

                D3D11_SHADER_VARIABLE_DESC desc;
                @delegate(_nativePointer, &desc);
                return desc;
            }
        }

        protected override void DisposeImpl() {
            throw new NotImplementedException("Cannot dispose Reflection members as it will be cleaned up when Release reflector.");
        }
    }
}
