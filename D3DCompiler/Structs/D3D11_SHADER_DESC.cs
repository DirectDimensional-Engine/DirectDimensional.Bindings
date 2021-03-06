using System.Runtime.InteropServices;
using DirectDimensional.Bindings.Direct3D11;

#pragma warning disable IDE0044
#pragma warning disable IDE0051

namespace DirectDimensional.Bindings.D3DCompiler {
    public struct D3D11_SHADER_DESC {
        public uint Version;

        public IntPtr pCreator;
        public string? Creator => Marshal.PtrToStringAnsi(pCreator);

        public uint Flags;

        public uint ConstantBuffers; 
        public uint BoundResources;
        public uint InputParameters; 
        public uint OutputParameters;

        public uint InstructionCount;
        public uint TempRegisterCount; 
        public uint TempArrayCount;
        public uint DefCount;
        public uint DclCount;
        public uint TextureNormalInstructions; 
        public uint TextureLoadInstructions; 
        public uint TextureCompInstructions; 
        public uint TextureBiasInstructions; 
        public uint TextureGradientInstructions; 
        public uint FloatInstructionCount; 
        public uint IntInstructionCount; 
        public uint UintInstructionCount;
        public uint StaticFlowControlCount;
        public uint DynamicFlowControlCount; 
        public uint MacroInstructionCount; 
        public uint ArrayInstructionCount; 
        public uint CutInstructionCount; 
        public uint EmitInstructionCount;
        private D3D11_PRIMITIVE_TOPOLOGY GSOutputTopology;
        private uint GSMaxOutputVertexCount;
        private uint InputPrimitive;
        public uint PatchConstantParameters;
        private uint cGSInstanceCount;
        private uint cControlPoints;
        private uint HSOutputPrimitive;
        private uint HSPartitioning; 
        private uint TessellatorDomain; 

        public uint cBarrierInstructions; 
        public uint cInterlockedInstructions; 
        public uint cTextureStoreInstructions;
    }
}

#pragma warning restore IDE0044
#pragma warning restore IDE0051