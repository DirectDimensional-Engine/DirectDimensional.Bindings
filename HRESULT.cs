using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings {
    public struct HRESULT : IEquatable<HRESULT>, IFormattable {
        private static readonly ImmutableDictionary<int, string> _names;

        static HRESULT() {
            var builder = ImmutableDictionary.CreateBuilder<int, string>();
            builder.Add(0, "S_OK");
            builder.Add(1, "S_FALSE");
            builder.Add(unchecked((int)0x80004003), "E_POINTER");
            builder.Add(unchecked((int)0x80004005), "E_FAIL");
            builder.Add(unchecked((int)0x80004002), "E_NOINTERFACE");
            builder.Add(unchecked((int)0x80070057), "E_INVALIDARG");
            builder.Add(unchecked((int)0x80070005), "E_ACCESSDENIED");
            builder.Add(unchecked((int)0x80004001), "E_NOTIMPL");
            builder.Add(unchecked((int)0x8007139F), "E_NOT_VALID_STATE");
            builder.Add(unchecked((int)0x8000FFFF), "E_UNEXPECTED");
            builder.Add(unchecked((int)0x8007007A), "E_NOT_SUFFICIENT_BUFFER");
            builder.Add(unchecked((int)0x8000000B), "E_BOUNDS");
            builder.Add(unchecked((int)0x8007000E), "E_OUTOFMEMORY");
            builder.Add(unchecked((int)0x087A0001), "DXGI_STATUS_OCCLUDED");
            builder.Add(unchecked((int)0x087A0002), "DXGI_STATUS_CLIPPED");
            builder.Add(unchecked((int)0x087A0004), "DXGI_STATUS_NO_REDIRECTION");
            builder.Add(unchecked((int)0x087A0005), "DXGI_STATUS_NO_DESKTOP_ACCESS");
            builder.Add(unchecked((int)0x087A0006), "DXGI_STATUS_GRAPHICS_VIDPN_SOURCE_IN_USE");
            builder.Add(unchecked((int)0x087A0007), "DXGI_STATUS_MODE_CHANGED");
            builder.Add(unchecked((int)0x087A0008), "DXGI_STATUS_MODE_CHANGE_IN_PROGRESS");
            builder.Add(unchecked((int)0x887A0001), "DXGI_ERROR_INVALID_CALL");
            builder.Add(unchecked((int)0x887A0002), "DXGI_ERROR_NOT_FOUND");
            builder.Add(unchecked((int)0x887A0003), "DXGI_ERROR_MORE_DATA");
            builder.Add(unchecked((int)0x887A0004), "DXGI_ERROR_UNSUPPORTED");
            builder.Add(unchecked((int)0x887A0005), "DXGI_ERROR_DEVICE_REMOVED");
            builder.Add(unchecked((int)0x887A0006), "DXGI_ERROR_DEVICE_HUNG");
            builder.Add(unchecked((int)0x887A0007), "DXGI_ERROR_DEVICE_RESET");
            builder.Add(unchecked((int)0x887A000A), "DXGI_ERROR_WAS_STILL_DRAWING");
            builder.Add(unchecked((int)0x887A000B), "DXGI_ERROR_FRAME_STATISTICS_DISJOINT");
            builder.Add(unchecked((int)0x887A000C), "DXGI_ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE");
            builder.Add(unchecked((int)0x887A0020), "DXGI_ERROR_DRIVER_INTERNAL_ERROR");
            builder.Add(unchecked((int)0x887A0021), "DXGI_ERROR_NONEXCLUSIVE");
            builder.Add(unchecked((int)0x887A0022), "DXGI_ERROR_NOT_CURRENTLY_AVAILABLE");
            builder.Add(unchecked((int)0x887A0023), "DXGI_ERROR_REMOTE_CLIENT_DISCONNECTED");
            builder.Add(unchecked((int)0x887A0024), "DXGI_ERROR_REMOTE_OUTOFMEMORY");
            builder.Add(unchecked((int)0x887A0026), "DXGI_ERROR_ACCESS_LOST");
            builder.Add(unchecked((int)0x887A0027), "DXGI_ERROR_WAIT_TIMEOUT");
            builder.Add(unchecked((int)0x887A0028), "DXGI_ERROR_SESSION_DISCONNECTED");
            builder.Add(unchecked((int)0x887A0029), "DXGI_ERROR_RESTRICT_TO_OUTPUT_STALE");
            builder.Add(unchecked((int)0x887A002A), "DXGI_ERROR_CANNOT_PROTECT_CONTENT");
            builder.Add(unchecked((int)0x887A002B), "DXGI_ERROR_ACCESS_DENIED");
            builder.Add(unchecked((int)0x887A002C), "DXGI_ERROR_NAME_ALREADY_EXISTS");
            builder.Add(unchecked((int)0x887A002D), "DXGI_ERROR_SDK_COMPONENT_MISSING");
            builder.Add(unchecked((int)0x887A002E), "DXGI_ERROR_NOT_CURRENT");
            builder.Add(unchecked((int)0x887A0030), "DXGI_ERROR_HW_PROTECTION_OUTOFMEMORY");
            builder.Add(unchecked((int)0x887A0031), "DXGI_ERROR_DYNAMIC_CODE_POLICY_VIOLATION");
            builder.Add(unchecked((int)0x887A0032), "DXGI_ERROR_NON_COMPOSITED_UI");
            builder.Add(unchecked((int)0x087A0009), "DXGI_STATUS_UNOCCLUDED");
            builder.Add(unchecked((int)0x087A000A), "DXGI_STATUS_DDA_WAS_STILL_DRAWING");
            builder.Add(unchecked((int)0x887A0025), "DXGI_ERROR_MODE_CHANGE_IN_PROGRESS");
            builder.Add(unchecked((int)0x087A002F), "DXGI_STATUS_PRESENT_REQUIRED");
            builder.Add(unchecked((int)0x887A0033), "DXGI_ERROR_CACHE_CORRUPT");
            builder.Add(unchecked((int)0x887A0034), "DXGI_ERROR_CACHE_FULL");
            builder.Add(unchecked((int)0x887A0035), "DXGI_ERROR_CACHE_HASH_COLLISION");
            builder.Add(unchecked((int)0x887A0036), "DXGI_ERROR_ALREADY_EXISTS");
            builder.Add(unchecked((int)0x887B0001), "DXGI_DDI_ERR_WASSTILLDRAWING");
            builder.Add(unchecked((int)0x887B0002), "DXGI_DDI_ERR_UNSUPPORTED");
            builder.Add(unchecked((int)0x887B0003), "DXGI_DDI_ERR_NONEXCLUSIVE");
            builder.Add(unchecked((int)0x88982F04), "WINCODEC_ERR_WRONGSTATE");
            builder.Add(unchecked((int)0x88982F05), "WINCODEC_ERR_VALUEOUTOFRANGE");
            builder.Add(unchecked((int)0x88982F07), "WINCODEC_ERR_UNKNOWNIMAGEFORMAT");
            builder.Add(unchecked((int)0x88982F0B), "WINCODEC_ERR_UNSUPPORTEDVERSION");
            builder.Add(unchecked((int)0x88982F0C), "WINCODEC_ERR_NOTINITIALIZED");
            builder.Add(unchecked((int)0x88982F0D), "WINCODEC_ERR_ALREADYLOCKED");
            builder.Add(unchecked((int)0x88982F40), "WINCODEC_ERR_PROPERTYNOTFOUND");
            builder.Add(unchecked((int)0x88982F41), "WINCODEC_ERR_PROPERTYNOTSUPPORTED");
            builder.Add(unchecked((int)0x88982F42), "WINCODEC_ERR_PROPERTYSIZE");
            builder.Add(unchecked((int)0x88982F43), "WINCODEC_ERR_CODECPRESENT");
            builder.Add(unchecked((int)0x88982F44), "WINCODEC_ERR_CODECNOTHUMBNAIL");
            builder.Add(unchecked((int)0x88982F45), "WINCODEC_ERR_PALETTEUNAVAILABLE");
            builder.Add(unchecked((int)0x88982F46), "WINCODEC_ERR_CODECTOOMANYSCANLINES");
            builder.Add(unchecked((int)0x88982F48), "WINCODEC_ERR_INTERNALERROR");
            builder.Add(unchecked((int)0x88982F49), "WINCODEC_ERR_SOURCERECTDOESNOTMATCHDIMENSIONS");
            builder.Add(unchecked((int)0x88982F50), "WINCODEC_ERR_COMPONENTNOTFOUND");
            builder.Add(unchecked((int)0x88982F51), "WINCODEC_ERR_IMAGESIZEOUTOFRANGE");
            builder.Add(unchecked((int)0x88982F52), "WINCODEC_ERR_TOOMUCHMETADATA");
            builder.Add(unchecked((int)0x88982F60), "WINCODEC_ERR_BADIMAGE");
            builder.Add(unchecked((int)0x88982F61), "WINCODEC_ERR_BADHEADER");
            builder.Add(unchecked((int)0x88982F62), "WINCODEC_ERR_FRAMEMISSING");
            builder.Add(unchecked((int)0x88982F63), "WINCODEC_ERR_BADMETADATAHEADER");
            builder.Add(unchecked((int)0x88982F70), "WINCODEC_ERR_BADSTREAMDATA");
            builder.Add(unchecked((int)0x88982F71), "WINCODEC_ERR_STREAMWRITE");
            builder.Add(unchecked((int)0x88982F72), "WINCODEC_ERR_STREAMREAD");
            builder.Add(unchecked((int)0x88982F73), "WINCODEC_ERR_STREAMNOTAVAILABLE");
            builder.Add(unchecked((int)0x88982F80), "WINCODEC_ERR_UNSUPPORTEDPIXELFORMAT");
            builder.Add(unchecked((int)0x88982F81), "WINCODEC_ERR_UNSUPPORTEDOPERATION");
            builder.Add(unchecked((int)0x88982F8A), "WINCODEC_ERR_INVALIDREGISTRATION");
            builder.Add(unchecked((int)0x88982F8B), "WINCODEC_ERR_COMPONENTINITIALIZEFAILURE");
            builder.Add(unchecked((int)0x88982F8C), "WINCODEC_ERR_INSUFFICIENTBUFFER");
            builder.Add(unchecked((int)0x88982F8D), "WINCODEC_ERR_DUPLICATEMETADATAPRESENT");
            builder.Add(unchecked((int)0x88982F8E), "WINCODEC_ERR_PROPERTYUNEXPECTEDTYPE");
            builder.Add(unchecked((int)0x88982F8F), "WINCODEC_ERR_UNEXPECTEDSIZE");
            builder.Add(unchecked((int)0x88982F90), "WINCODEC_ERR_INVALIDQUERYREQUEST");
            builder.Add(unchecked((int)0x88982F91), "WINCODEC_ERR_UNEXPECTEDMETADATATYPE");
            builder.Add(unchecked((int)0x88982F92), "WINCODEC_ERR_REQUESTONLYVALIDATMETADATAROOT");
            builder.Add(unchecked((int)0x88982F93), "WINCODEC_ERR_INVALIDQUERYCHARACTER");
            builder.Add(unchecked((int)0x88982F94), "WINCODEC_ERR_WIN32ERROR");
            builder.Add(unchecked((int)0x88982F95), "WINCODEC_ERR_INVALIDPROGRESSIVELEVEL");
            builder.Add(unchecked((int)0x88982F96), "WINCODEC_ERR_INVALIDJPEGSCANINDEX");
            builder.Add(unchecked((int)0x887602BC), "D3DERR_BADMAJORVERSION");
            builder.Add(unchecked((int)0x887602BD), "D3DERR_BADMINORVERSION");
            builder.Add(unchecked((int)0x88760802), "D3DERR_COLORKEYATTACHED");
            builder.Add(unchecked((int)0x887602C3), "D3DERR_DEVICEAGGREGATED");
            builder.Add(unchecked((int)0x887602CD), "D3DERR_EXECUTE_CLIPPED_FAILED");
            builder.Add(unchecked((int)0x887602C6), "D3DERR_EXECUTE_CREATE_FAILED");
            builder.Add(unchecked((int)0x887602C7), "D3DERR_EXECUTE_DESTROY_FAILED");
            builder.Add(unchecked((int)0x887602CC), "D3DERR_EXECUTE_FAILED");
            builder.Add(unchecked((int)0x887602C8), "D3DERR_EXECUTE_LOCK_FAILED");
            builder.Add(unchecked((int)0x887602CA), "D3DERR_EXECUTE_LOCKED");
            builder.Add(unchecked((int)0x887602CB), "D3DERR_EXECUTE_NOT_LOCKED");
            builder.Add(unchecked((int)0x887602C9), "D3DERR_EXECUTE_UNLOCK_FAILED");
            builder.Add(unchecked((int)0x88760302), "D3DERR_INBEGIN");
            builder.Add(unchecked((int)0x88760835), "D3DERR_INBEGINSTATEBLOCK");
            builder.Add(unchecked((int)0x887602C2), "D3DERR_INITFAILED");
            builder.Add(unchecked((int)0x887602C1), "D3DERR_INVALID_DEVICE");
            builder.Add(unchecked((int)0x887602DF), "D3DERR_INVALIDCURRENTVIEWPORT");
            builder.Add(unchecked((int)0x88760824), "D3DERR_INVALIDMATRIX");
            builder.Add(unchecked((int)0x887602E8), "D3DERR_INVALIDPALETTE");
            builder.Add(unchecked((int)0x887602E0), "D3DERR_INVALIDPRIMITIVETYPE");
            builder.Add(unchecked((int)0x887602E3), "D3DERR_INVALIDRAMPTEXTURE");
            builder.Add(unchecked((int)0x88760834), "D3DERR_INVALIDSTATEBLOCK");
            builder.Add(unchecked((int)0x88760800), "D3DERR_INVALIDVERTEXFORMAT");
            builder.Add(unchecked((int)0x887602E1), "D3DERR_INVALIDVERTEXTYPE");
            builder.Add(unchecked((int)0x887602EE), "D3DERR_LIGHT_SET_FAILED");
            builder.Add(unchecked((int)0x887602EF), "D3DERR_LIGHTHASVIEWPORT");
            builder.Add(unchecked((int)0x887602F0), "D3DERR_LIGHTNOTINTHISVIEWPORT");
            builder.Add(unchecked((int)0x887602E4), "D3DERR_MATERIAL_CREATE_FAILED");
            builder.Add(unchecked((int)0x887602E5), "D3DERR_MATERIAL_DESTROY_FAILED");
            builder.Add(unchecked((int)0x887602E7), "D3DERR_MATERIAL_GETDATA_FAILED");
            builder.Add(unchecked((int)0x887602E6), "D3DERR_MATERIAL_SETDATA_FAILED");
            builder.Add(unchecked((int)0x887602DA), "D3DERR_MATRIX_CREATE_FAILED");
            builder.Add(unchecked((int)0x887602DB), "D3DERR_MATRIX_DESTROY_FAILED");
            builder.Add(unchecked((int)0x887602DD), "D3DERR_MATRIX_GETDATA_FAILED");
            builder.Add(unchecked((int)0x887602DC), "D3DERR_MATRIX_SETDATA_FAILED");
            builder.Add(unchecked((int)0x88760307), "D3DERR_NOCURRENTVIEWPORT");
            builder.Add(unchecked((int)0x88760303), "D3DERR_NOTINBEGIN");
            builder.Add(unchecked((int)0x88760836), "D3DERR_NOTINBEGINSTATEBLOCK");
            builder.Add(unchecked((int)0x88760304), "D3DERR_NOVIEWPORTS");
            builder.Add(unchecked((int)0x887602FA), "D3DERR_SCENE_BEGIN_FAILED");
            builder.Add(unchecked((int)0x887602FB), "D3DERR_SCENE_END_FAILED");
            builder.Add(unchecked((int)0x887602F8), "D3DERR_SCENE_IN_SCENE");
            builder.Add(unchecked((int)0x887602F9), "D3DERR_SCENE_NOT_IN_SCENE");
            builder.Add(unchecked((int)0x887602DE), "D3DERR_SETVIEWPORTDATA_FAILED");
            builder.Add(unchecked((int)0x88760817), "D3DERR_STENCILBUFFER_NOTPRESENT");
            builder.Add(unchecked((int)0x887602EB), "D3DERR_SURFACENOTINVIDMEM");
            builder.Add(unchecked((int)0x887602E2), "D3DERR_TEXTURE_BADSIZE");
            builder.Add(unchecked((int)0x887602D1), "D3DERR_TEXTURE_CREATE_FAILED");
            builder.Add(unchecked((int)0x887602D2), "D3DERR_TEXTURE_DESTROY_FAILED");
            builder.Add(unchecked((int)0x887602D9), "D3DERR_TEXTURE_GETSURF_FAILED");
            builder.Add(unchecked((int)0x887602D5), "D3DERR_TEXTURE_LOAD_FAILED");
            builder.Add(unchecked((int)0x887602D3), "D3DERR_TEXTURE_LOCK_FAILED");
            builder.Add(unchecked((int)0x887602D7), "D3DERR_TEXTURE_LOCKED");
            builder.Add(unchecked((int)0x887602D0), "D3DERR_TEXTURE_NO_SUPPORT");
            builder.Add(unchecked((int)0x887602D8), "D3DERR_TEXTURE_NOT_LOCKED");
            builder.Add(unchecked((int)0x887602D6), "D3DERR_TEXTURE_SWAP_FAILED");
            builder.Add(unchecked((int)0x887602D4), "D3DERR_TEXTURE_UNLOCK_FAILED");
            builder.Add(unchecked((int)0x88760823), "D3DERR_TOOMANYPRIMITIVES");
            builder.Add(unchecked((int)0x88760825), "D3DERR_TOOMANYVERTICES");
            builder.Add(unchecked((int)0x8876080D), "D3DERR_VBUF_CREATE_FAILED");
            builder.Add(unchecked((int)0x8876080E), "D3DERR_VERTEXBUFFERLOCKED");
            builder.Add(unchecked((int)0x8876080C), "D3DERR_VERTEXBUFFEROPTIMIZED");
            builder.Add(unchecked((int)0x8876080F), "D3DERR_VERTEXBUFFERUNLOCKFAILED");
            builder.Add(unchecked((int)0x88760305), "D3DERR_VIEWPORTDATANOTSET");
            builder.Add(unchecked((int)0x88760306), "D3DERR_VIEWPORTHASNODEVICE");
            builder.Add(unchecked((int)0x887602E9), "D3DERR_ZBUFF_NEEDS_SYSTEMMEMORY");
            builder.Add(unchecked((int)0x887602EA), "D3DERR_ZBUFF_NEEDS_VIDEOMEMORY");
            builder.Add(unchecked((int)0x88760816), "D3DERR_ZBUFFER_NOTPRESENT");
            builder.Add(unchecked((int)0x8876087D), "D3DERR_CANNOTPROTECTCONTENT");
            builder.Add(unchecked((int)0x88760821), "D3DERR_CONFLICTINGRENDERSTATE");
            builder.Add(unchecked((int)0x8876081E), "D3DERR_CONFLICTINGTEXTUREFILTER");
            builder.Add(unchecked((int)0x88760826), "D3DERR_CONFLICTINGTEXTUREPALETTE");
            builder.Add(unchecked((int)0x88760874), "D3DERR_DEVICEHUNG");
            builder.Add(unchecked((int)0x88760868), "D3DERR_DEVICELOST");
            builder.Add(unchecked((int)0x88760869), "D3DERR_DEVICENOTRESET");
            builder.Add(unchecked((int)0x88760870), "D3DERR_DEVICEREMOVED");
            builder.Add(unchecked((int)0x88760827), "D3DERR_DRIVERINTERNALERROR");
            builder.Add(unchecked((int)0x8876086D), "D3DERR_DRIVERINVALIDCALL");
            builder.Add(unchecked((int)0x8876086C), "D3DERR_INVALIDCALL");
            builder.Add(unchecked((int)0x8876086B), "D3DERR_INVALIDDEVICE");
            builder.Add(unchecked((int)0x88760867), "D3DERR_MOREDATA");
            builder.Add(unchecked((int)0x8876086A), "D3DERR_NOTAVAILABLE");
            builder.Add(unchecked((int)0x88760866), "D3DERR_NOTFOUND");
            builder.Add(unchecked((int)0x8876017C), "D3DERR_OUTOFVIDEOMEMORY");
            builder.Add(unchecked((int)0x88760884), "D3DERR_PRESENT_STATISTICS_DISJOINT");
            builder.Add(unchecked((int)0x8876081D), "D3DERR_TOOMANYOPERATIONS");
            builder.Add(unchecked((int)0x8876081C), "D3DERR_UNSUPPORTEDALPHAARG");
            builder.Add(unchecked((int)0x8876081B), "D3DERR_UNSUPPORTEDALPHAOPERATION");
            builder.Add(unchecked((int)0x8876081A), "D3DERR_UNSUPPORTEDCOLORARG");
            builder.Add(unchecked((int)0x88760819), "D3DERR_UNSUPPORTEDCOLOROPERATION");
            builder.Add(unchecked((int)0x8876087E), "D3DERR_UNSUPPORTEDCRYPTO");
            builder.Add(unchecked((int)0x8876081F), "D3DERR_UNSUPPORTEDFACTORVALUE");
            builder.Add(unchecked((int)0x8876087B), "D3DERR_UNSUPPORTEDOVERLAY");
            builder.Add(unchecked((int)0x8876087C), "D3DERR_UNSUPPORTEDOVERLAYFORMAT");
            builder.Add(unchecked((int)0x88760822), "D3DERR_UNSUPPORTEDTEXTUREFILTER");
            builder.Add(unchecked((int)0x8876021C), "D3DERR_WASSTILLDRAWING");
            builder.Add(unchecked((int)0x88760818), "D3DERR_WRONGTEXTUREFORMAT");
            builder.Add(unchecked((int)0x88760BB8), "D3DERR_COMMAND_UNPARSED");
            _names = builder.ToImmutable();
        }

        private readonly int _code;
        public int Code => _code;

        public HRESULT(int code) {
            _code = code;
        }

        public bool Succeed => _code >= 0;
        public bool Failed => _code < 0;

        public override string ToString() {
            return _code.ToString();
        }

        public bool Equals(HRESULT other) {
            return other._code == _code;
        }

        public override bool Equals([NotNullWhen(true)] object? obj) {
            return _code.Equals(obj);
        }

        public override int GetHashCode() {
            return _code;   // Hashcode of an integer is itself
        }

        public string ToString(string? format) {
            if (format == null) return _code.ToString(format);

            if (format.ToUpperInvariant() == "NAME") {
                if (_names.TryGetValue(_code, out var name)) {
                    return name;
                }
            }

            return _code.ToString(format);
        }

        public string ToString(string? format, IFormatProvider? formatProvider) {
            if (format == null) return _code.ToString(null, formatProvider);

            if (format.ToUpperInvariant() == "NAME") {
                if (_names.TryGetValue(_code, out var name)) {
                    return name;
                }
            }

            return _code.ToString(format, formatProvider);
        }

        public void ThrowExceptionIfError(Action? preThrowAction = null) {
            if (Failed) {
                preThrowAction?.Invoke();

                var excep = Marshal.GetExceptionForHR(_code);
                if (excep != null) {
                    throw excep;
                }
            }
        }

        public void PrintExceptionIfError() {
            if (Failed) {
                var excep = Marshal.GetExceptionForHR(_code);
                if (excep != null) {
                    var col = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(excep.ToString());
                    Console.ForegroundColor = col;
                }
            }
        }

        [Conditional("DEBUG")]
        public void ThrowExceptionIfErrorOnDebug(Action? preThrowAction = null) {
            if (Failed) {
                preThrowAction?.Invoke();

                var excep = Marshal.GetExceptionForHR(_code);
                if (excep != null) throw excep;
            }
        }

        public static bool operator ==(HRESULT l, HRESULT r) => l.Code == r.Code;
        public static bool operator !=(HRESULT l, HRESULT r) => l.Code != r.Code;

        public static implicit operator HRESULTCodes(HRESULT hr) => (HRESULTCodes)hr.Code;
        public static implicit operator HRESULT(HRESULTCodes code) => new((int)code);

        public static implicit operator int(HRESULT hr) => hr.Code;
        public static implicit operator HRESULT(int code) => new(code);
    }
}
