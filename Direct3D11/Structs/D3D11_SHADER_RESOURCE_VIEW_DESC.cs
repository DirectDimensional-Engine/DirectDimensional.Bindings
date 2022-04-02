using System;
using System.Runtime.InteropServices;
using DirectDimensional.Bindings.DXGI;

namespace DirectDimensional.Bindings.Direct3D11 {
    public enum D3D11_SRV_DIMENSION {
        Unknown = 0,
        Buffer = 1,
        Texture1D = 2,
        Texture1DArray = 3,
        Texture2D = 4,
        Texture2DArray = 5,
        Texture2DMS = 6,
        Texture2DMSArray = 7,
        Texture3D = 8,
        TextureCube = 9,
        TextureCubeArray = 10,
        BufferEX = 11,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct D3D11_BUFFER_SRV {
        [FieldOffset(0)] public uint FirstElement;
        [FieldOffset(4)] public uint ElementOffset;

        [FieldOffset(0)] public uint NumElements;
        [FieldOffset(4)] public uint ElementWidth;
    }

    public struct D3D11_BUFFEREX_SRV {
        public uint FirstElement;
        public uint NumElements;
        public uint Flags;
    }

    public struct D3D11_TEX1D_SRV {
        public uint MostDetailedMip;
        public uint MipLevels;
    }

    public struct D3D11_TEX1D_ARRAY_SRV {
        public uint MostDetailedMip;
        public uint MipLevels;
        public uint FirstArraySlice;
        public uint ArraySize;
    }

    public struct D3D11_TEX2D_SRV {
        public uint MostDetailedMip;
        public uint MipLevels;
    }

    public struct D3D11_TEX2D_ARRAY_SRV {
        public uint MostDetailedMip;
        public uint MipLevels;
        public uint FirstArraySlice;
        public uint ArraySize;
    }

    public struct D3D11_TEX3D_SRV {
        public uint MostDetailedMip;
        public uint MipLevels;
    }

    public struct D3D11_TEXCUBE_SRV {
        public uint MostDetailedMip;
        public uint MipLevels;
    }

    public struct D3D11_TEXCUBE_ARRAY_SRV {
        public uint MostDetailedMip;
        public uint MipLevels;
        public uint First2DArrayFace;
        public uint NumCubes;
    }

    public struct D3D11_TEX2DMS_SRV {
        public uint UnusedField;
    }

    public struct D3D11_TEX2DMS_ARRAY_SRV {
        public uint FirstArraySlice;
        public uint ArraySize;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct D3D11_SHADER_RESOURCE_VIEW_DESC {
        [FieldOffset(0)] public DXGI_FORMAT Format;
        [FieldOffset(4)] public D3D11_SRV_DIMENSION ViewDimension;

        [FieldOffset(8)] public D3D11_BUFFER_SRV Buffer;
        [FieldOffset(8)] public D3D11_TEX1D_SRV Texture1D;
        [FieldOffset(8)] public D3D11_TEX1D_ARRAY_SRV Texture1DArray;
        [FieldOffset(8)] public D3D11_TEX2D_SRV Texture2D;
        [FieldOffset(8)] public D3D11_TEX2D_ARRAY_SRV Texture2DArray;
        [FieldOffset(8)] public D3D11_TEX2DMS_SRV Texture2DMS;
        [FieldOffset(8)] public D3D11_TEX2DMS_ARRAY_SRV Texture2DMSArray;
        [FieldOffset(8)] public D3D11_TEX3D_SRV Texture3D;
        [FieldOffset(8)] public D3D11_TEXCUBE_SRV TextureCube;
        [FieldOffset(8)] public D3D11_TEXCUBE_ARRAY_SRV TextureCubeArray;
        [FieldOffset(8)] public D3D11_BUFFEREX_SRV BufferEx;
    }
}
