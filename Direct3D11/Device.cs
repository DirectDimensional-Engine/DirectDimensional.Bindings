using System.Runtime.InteropServices;
using DirectDimensional.Bindings.DXGI;

namespace DirectDimensional.Bindings.Direct3D11 {
    [Guid("db6f6ddb-ac77-4e88-8253-819df9bbf140")]
    public sealed unsafe class Device : ComObject {
        public D3D_FEATURE_LEVEL FeatureLevel {
            get {
                IntPtr address = (*(IntPtr*)_nativePointer) + 37 * IntPtr.Size;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D_FEATURE_LEVEL>)(*(IntPtr*)address);

                return @delegate(_nativePointer);
            }
        }
        public HRESULT DeviceRemovedReason {
            get {
                IntPtr address = (*(IntPtr*)_nativePointer) + 39 * IntPtr.Size;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, HRESULT>)(*(IntPtr*)address);

                return @delegate(_nativePointer);
            }
        }
        public DeviceContext ImmediateContext {
            get {
                IntPtr address = (*(IntPtr*)_nativePointer) + 40 * IntPtr.Size;
                var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, void**, void>)(*(IntPtr*)address);

                void* pCtx;
                @delegate(_nativePointer, &pCtx);

                return new(new IntPtr(pCtx));
            }
        }

        public Device(IntPtr ptr) : base(ptr) { }

        public HRESULT CreateBuffer(D3D11_BUFFER_DESC desc, D3D11_SUBRESOURCE_DATA* pInitialData, out Buffer? output) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 3 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_BUFFER_DESC*, D3D11_SUBRESOURCE_DATA*, out IntPtr, HRESULT>)(*(IntPtr*)address);

            HRESULT hr = @delegate(_nativePointer, &desc, pInitialData, out var ppBuffer);
            if (hr.Failed) {
                output = null;
                return hr;
            }

            output = new(ppBuffer);
            return hr;
        }

        public HRESULT CreateTexture1D(D3D11_TEXTURE1D_DESC desc, D3D11_SUBRESOURCE_DATA* pInitialData, out Texture1D? output) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 4 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_TEXTURE1D_DESC*, D3D11_SUBRESOURCE_DATA*, void**, HRESULT>)(*(IntPtr*)address);

            void* pTexture;
            HRESULT hr = @delegate(_nativePointer, &desc, pInitialData, &pTexture);
            if (hr.Failed) {
                output = null;
                return hr;
            }

            output = new Texture1D(new IntPtr(pTexture));
            return hr;
        }

        public HRESULT CreateTexture2D(D3D11_TEXTURE2D_DESC desc, D3D11_SUBRESOURCE_DATA* pInitialData, out Texture2D? output) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 5 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_TEXTURE2D_DESC*, D3D11_SUBRESOURCE_DATA*, void**, HRESULT>)(*(IntPtr*)address);

            void* pTexture;
            HRESULT hr = @delegate(_nativePointer, &desc, pInitialData, &pTexture);
            if (hr.Failed) {
                output = null;
                return hr;
            }

            output = new Texture2D(new IntPtr(pTexture));
            return hr;
        }

        public HRESULT CreateTexture3D(D3D11_TEXTURE3D_DESC desc, D3D11_SUBRESOURCE_DATA* pInitialData, out Texture3D? output) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 6 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_TEXTURE3D_DESC*, D3D11_SUBRESOURCE_DATA*, void**, HRESULT>)(*(IntPtr*)address);

            void* pTexture;
            HRESULT hr = @delegate(_nativePointer, &desc, pInitialData, &pTexture);
            if (hr.Failed) {
                output = null;
                return hr;
            }

            output = new Texture3D(new IntPtr(pTexture));
            return hr;
        }

        public HRESULT CreateShaderResourceView(Resource resource, D3D11_SHADER_RESOURCE_VIEW_DESC* pDesc, out ShaderResourceView? view) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 7 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, D3D11_SHADER_RESOURCE_VIEW_DESC*, void**, HRESULT>)(*(IntPtr*)address);

            void* pSRV;
            HRESULT hr = @delegate(_nativePointer, resource._nativePointer, pDesc, &pSRV);
            if (hr.Failed) {
                view = null;
                return hr;
            }

            view = new(new IntPtr(pSRV));
            return hr;
        }

        public HRESULT CreateRenderTargetView(Resource resource, D3D11_RENDER_TARGET_VIEW_DESC* pDesc, out RenderTargetView? output) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 9 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, D3D11_RENDER_TARGET_VIEW_DESC*, void**, HRESULT>)(*(IntPtr*)address);

            void* pRTV;
            HRESULT hr = @delegate(_nativePointer, resource._nativePointer, pDesc, &pRTV);
            if (hr.Failed) {
                output = null;
                return hr;
            }

            output = new(new IntPtr(pRTV));
            return hr;
        }

        public HRESULT CreateDepthStencilView(Resource resource, D3D11_DEPTH_STENCIL_VIEW_DESC* pDesc, out DepthStencilView? output) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 10 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, D3D11_DEPTH_STENCIL_VIEW_DESC*, void**, HRESULT>)(*(IntPtr*)address);

            void* pDSV;
            HRESULT hr = @delegate(_nativePointer, resource._nativePointer, pDesc, &pDSV);
            if (hr.Failed) {
                output = null;
                return hr;
            }

            output = new(new IntPtr(pDSV));
            return hr;
        }

        public HRESULT CreateInputLayout(D3D11_INPUT_ELEMENT_DESC[] elements, Blob vertexShaderBlob, out InputLayout? output) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 11 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_INPUT_ELEMENT_DESC*, uint, IntPtr, nuint, void**, HRESULT>)(*(IntPtr*)address);

            fixed (D3D11_INPUT_ELEMENT_DESC* pElement = &elements[0]) {
                void* pOutput;
                HRESULT hr = @delegate(_nativePointer, pElement, (uint)elements.Length, vertexShaderBlob.GetBufferPointer(), vertexShaderBlob.GetBufferSize(), &pOutput);
                if (hr.Failed) {
                    output = null;
                    return hr;
                }

                output = new(new IntPtr(pOutput));
                return hr;
            }
        }

        public HRESULT CreateVertexShader(Blob bytecode, out VertexShader? output) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 12 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, nuint, IntPtr, void**, HRESULT>)(*(IntPtr*)address);

            void* pOutput;
            HRESULT hr = @delegate(_nativePointer, bytecode.GetBufferPointer(), bytecode.GetBufferSize(), IntPtr.Zero, &pOutput);
            if (hr.Failed) {
                output = null;
                return hr;
            }

            output = new(new IntPtr(pOutput));
            return hr;
        }

        public HRESULT CreatePixelShader(Blob bytecode, out PixelShader? output) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 15 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, IntPtr, nuint, IntPtr, void**, HRESULT>)(*(IntPtr*)address);

            void* pOutput;
            HRESULT hr = @delegate(_nativePointer, bytecode.GetBufferPointer(), bytecode.GetBufferSize(), IntPtr.Zero, &pOutput);
            if (hr.Failed) {
                output = null;
                return hr;
            }

            output = new(new IntPtr(pOutput));
            return hr;
        }

        //public HRESULT CreateBlendState() {
        //    IntPtr address = (*(IntPtr*)_nativePointer) + 20 * IntPtr.Size;
        //}

        public HRESULT CreateDepthStencilState(D3D11_DEPTH_STENCIL_DESC desc, out DepthStencilState? output) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 21 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_DEPTH_STENCIL_DESC*, void**, HRESULT>)(*(IntPtr*)address);

            void* pOutput;
            HRESULT hr = @delegate(_nativePointer, &desc, &pOutput);
            if (hr.Failed) {
                output = null;
                return hr;
            }

            output = new(new IntPtr(pOutput));
            return hr;
        }

        public HRESULT CreateSamplerState(D3D11_SAMPLER_DESC desc, out SamplerState? output) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 23 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, D3D11_SAMPLER_DESC*, void**, HRESULT>)(*(IntPtr*)address);

            void* pOutput;
            HRESULT hr = @delegate(_nativePointer, &desc, &pOutput);
            if (hr.Failed) {
                output = null;
                return hr;
            }

            output = new(new IntPtr(pOutput));
            return hr;
        }

        public HRESULT CreateDeferredContext(uint flags, out DeviceContext? output) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 27 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, uint, void**, HRESULT>)(*(IntPtr*)address);

            void* pOutput;
            HRESULT hr = @delegate(_nativePointer, flags, &pOutput);
            if (hr.Failed) {
                output = null;
                return hr;
            }

            output = new(new IntPtr(pOutput));
            return hr;
        }

        public HRESULT CheckFormatSupport(DXGI_FORMAT format, out uint formatSupport) {
            IntPtr address = (*(IntPtr*)_nativePointer) + 29 * IntPtr.Size;
            var @delegate = (delegate* unmanaged[Stdcall]<IntPtr, DXGI_FORMAT, uint*, HRESULT>)(*(IntPtr*)address);

            fixed (uint* ptr = &formatSupport) {
                return @delegate(_nativePointer, format, ptr);
            }
        }

        public HRESULT CreateVertexBuffer<T>(T[] vertices, bool dynamic, out Buffer? buffer) where T : unmanaged {
            D3D11_BUFFER_DESC desc = default;
            desc.StructureByteStride = (uint)sizeof(T);
            desc.ByteWidth = (uint)(vertices.Length * sizeof(T));
            desc.MiscFlags = D3D11_RESOURCE_MISC_FLAG.None;
            desc.BindFlags = D3D11_BIND_FLAG.VertexBuffer;

            if (dynamic) {
                desc.Usage = D3D11_USAGE.Dynamic;
                desc.CPUAccessFlags = D3D11_CPU_ACCESS_FLAG.Write;
            }

            fixed (T* pVertex = &vertices[0]) {
                D3D11_SUBRESOURCE_DATA srd = default;
                srd.pData = new IntPtr(pVertex);

                return CreateBuffer(desc, &srd, out buffer);
            }
        }

        public HRESULT CreateVertexBuffer<T>(Span<T> vertices, bool dynamic, out Buffer? buffer) where T : unmanaged {
            D3D11_BUFFER_DESC desc = default;
            desc.StructureByteStride = (uint)sizeof(T);
            desc.ByteWidth = (uint)(vertices.Length * sizeof(T));
            desc.MiscFlags = D3D11_RESOURCE_MISC_FLAG.None;
            desc.BindFlags = D3D11_BIND_FLAG.VertexBuffer;

            if (dynamic) {
                desc.Usage = D3D11_USAGE.Dynamic;
                desc.CPUAccessFlags = D3D11_CPU_ACCESS_FLAG.Write;
            }

            fixed (T* pVertex = vertices) {
                D3D11_SUBRESOURCE_DATA srd = default;
                srd.pData = new IntPtr(pVertex);

                return CreateBuffer(desc, &srd, out buffer);
            }
        }

        public HRESULT CreateIndexBuffer<T>(T[] indices, bool dynamic, out Buffer? buffer) where T : unmanaged {
            D3D11_BUFFER_DESC desc = default;
            desc.StructureByteStride = (uint)sizeof(T);
            desc.ByteWidth = (uint)(indices.Length * sizeof(T));
            desc.MiscFlags = D3D11_RESOURCE_MISC_FLAG.None;
            desc.BindFlags = D3D11_BIND_FLAG.IndexBuffer;

            if (dynamic) {
                desc.Usage = D3D11_USAGE.Dynamic;
                desc.CPUAccessFlags = D3D11_CPU_ACCESS_FLAG.Write;
            }

            fixed (T* pIndex = &indices[0]) {
                D3D11_SUBRESOURCE_DATA srd = default;
                srd.pData = new IntPtr(pIndex);

                return CreateBuffer(desc, &srd, out buffer);
            }
        }

        public HRESULT CreateIndexBuffer<T>(Span<T> indices, bool dynamic, out Buffer? buffer) where T : unmanaged {
            D3D11_BUFFER_DESC desc = default;
            desc.StructureByteStride = (uint)sizeof(T);
            desc.ByteWidth = (uint)(indices.Length * sizeof(T));
            desc.MiscFlags = D3D11_RESOURCE_MISC_FLAG.None;
            desc.BindFlags = D3D11_BIND_FLAG.IndexBuffer;

            if (dynamic) {
                desc.Usage = D3D11_USAGE.Dynamic;
                desc.CPUAccessFlags = D3D11_CPU_ACCESS_FLAG.Write;
            }

            fixed (T* pIndex = indices) {
                D3D11_SUBRESOURCE_DATA srd = default;
                srd.pData = new IntPtr(pIndex);

                return CreateBuffer(desc, &srd, out buffer);
            }
        }
    }
}
