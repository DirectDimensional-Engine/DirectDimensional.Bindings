﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectDimensional.Bindings {
    public enum HRESULTCodes {
        S_OK = 0,
        S_FALSE = 1,
        E_POINTER = unchecked((int)0x80004003),
        E_FAIL = unchecked((int)0x80004005),
        E_NOINTERFACE = unchecked((int)0x80004002),
        E_INVALIDARG = unchecked((int)0x80070057),
        E_ACCESSDENIED = unchecked((int)0x80070005),
        E_NOTIMPL = unchecked((int)0x80004001),
        E_NOT_VALID_STATE = unchecked((int)0x8007139F),
        E_UNEXPECTED = unchecked((int)0x8000FFFF),
        E_NOT_SUFFICIENT_BUFFER = unchecked((int)0x8007007A),
        E_BOUNDS = unchecked((int)0x8000000B),
        E_OUTOFMEMORY = unchecked((int)0x8007000E),
        DXGI_STATUS_OCCLUDED = unchecked((int)0x087A0001),
        DXGI_STATUS_CLIPPED = unchecked((int)0x087A0002),
        DXGI_STATUS_NO_REDIRECTION = unchecked((int)0x087A0004),
        DXGI_STATUS_NO_DESKTOP_ACCESS = unchecked((int)0x087A0005),
        DXGI_STATUS_GRAPHICS_VIDPN_SOURCE_IN_USE = unchecked((int)0x087A0006),
        DXGI_STATUS_MODE_CHANGED = unchecked((int)0x087A0007),
        DXGI_STATUS_MODE_CHANGE_IN_PROGRESS = unchecked((int)0x087A0008),
        DXGI_ERROR_INVALID_CALL = unchecked((int)0x887A0001),
        DXGI_ERROR_NOT_FOUND = unchecked((int)0x887A0002),
        DXGI_ERROR_MORE_DATA = unchecked((int)0x887A0003),
        DXGI_ERROR_UNSUPPORTED = unchecked((int)0x887A0004),
        DXGI_ERROR_DEVICE_REMOVED = unchecked((int)0x887A0005),
        DXGI_ERROR_DEVICE_HUNG = unchecked((int)0x887A0006),
        DXGI_ERROR_DEVICE_RESET = unchecked((int)0x887A0007),
        DXGI_ERROR_WAS_STILL_DRAWING = unchecked((int)0x887A000A),
        DXGI_ERROR_FRAME_STATISTICS_DISJOINT = unchecked((int)0x887A000B),
        DXGI_ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE = unchecked((int)0x887A000C),
        DXGI_ERROR_DRIVER_INTERNAL_ERROR = unchecked((int)0x887A0020),
        DXGI_ERROR_NONEXCLUSIVE = unchecked((int)0x887A0021),
        DXGI_ERROR_NOT_CURRENTLY_AVAILABLE = unchecked((int)0x887A0022),
        DXGI_ERROR_REMOTE_CLIENT_DISCONNECTED = unchecked((int)0x887A0023),
        DXGI_ERROR_REMOTE_OUTOFMEMORY = unchecked((int)0x887A0024),
        DXGI_ERROR_ACCESS_LOST = unchecked((int)0x887A0026),
        DXGI_ERROR_WAIT_TIMEOUT = unchecked((int)0x887A0027),
        DXGI_ERROR_SESSION_DISCONNECTED = unchecked((int)0x887A0028),
        DXGI_ERROR_RESTRICT_TO_OUTPUT_STALE = unchecked((int)0x887A0029),
        DXGI_ERROR_CANNOT_PROTECT_CONTENT = unchecked((int)0x887A002A),
        DXGI_ERROR_ACCESS_DENIED = unchecked((int)0x887A002B),
        DXGI_ERROR_NAME_ALREADY_EXISTS = unchecked((int)0x887A002C),
        DXGI_ERROR_SDK_COMPONENT_MISSING = unchecked((int)0x887A002D),
        DXGI_ERROR_NOT_CURRENT = unchecked((int)0x887A002E),
        DXGI_ERROR_HW_PROTECTION_OUTOFMEMORY = unchecked((int)0x887A0030),
        DXGI_ERROR_DYNAMIC_CODE_POLICY_VIOLATION = unchecked((int)0x887A0031),
        DXGI_ERROR_NON_COMPOSITED_UI = unchecked((int)0x887A0032),
        DXGI_STATUS_UNOCCLUDED = unchecked((int)0x087A0009),
        DXGI_STATUS_DDA_WAS_STILL_DRAWING = unchecked((int)0x087A000A),
        DXGI_ERROR_MODE_CHANGE_IN_PROGRESS = unchecked((int)0x887A0025),
        DXGI_STATUS_PRESENT_REQUIRED = unchecked((int)0x087A002F),
        DXGI_ERROR_CACHE_CORRUPT = unchecked((int)0x887A0033),
        DXGI_ERROR_CACHE_FULL = unchecked((int)0x887A0034),
        DXGI_ERROR_CACHE_HASH_COLLISION = unchecked((int)0x887A0035),
        DXGI_ERROR_ALREADY_EXISTS = unchecked((int)0x887A0036),
        DXGI_DDI_ERR_WASSTILLDRAWING = unchecked((int)0x887B0001),
        DXGI_DDI_ERR_UNSUPPORTED = unchecked((int)0x887B0002),
        DXGI_DDI_ERR_NONEXCLUSIVE = unchecked((int)0x887B0003),
        WINCODEC_ERR_WRONGSTATE = unchecked((int)0x88982F04),
        WINCODEC_ERR_VALUEOUTOFRANGE = unchecked((int)0x88982F05),
        WINCODEC_ERR_UNKNOWNIMAGEFORMAT = unchecked((int)0x88982F07),
        WINCODEC_ERR_UNSUPPORTEDVERSION = unchecked((int)0x88982F0B),
        WINCODEC_ERR_NOTINITIALIZED = unchecked((int)0x88982F0C),
        WINCODEC_ERR_ALREADYLOCKED = unchecked((int)0x88982F0D),
        WINCODEC_ERR_PROPERTYNOTFOUND = unchecked((int)0x88982F40),
        WINCODEC_ERR_PROPERTYNOTSUPPORTED = unchecked((int)0x88982F41),
        WINCODEC_ERR_PROPERTYSIZE = unchecked((int)0x88982F42),
        WINCODEC_ERR_CODECPRESENT = unchecked((int)0x88982F43),
        WINCODEC_ERR_CODECNOTHUMBNAIL = unchecked((int)0x88982F44),
        WINCODEC_ERR_PALETTEUNAVAILABLE = unchecked((int)0x88982F45),
        WINCODEC_ERR_CODECTOOMANYSCANLINES = unchecked((int)0x88982F46),
        WINCODEC_ERR_INTERNALERROR = unchecked((int)0x88982F48),
        WINCODEC_ERR_SOURCERECTDOESNOTMATCHDIMENSIONS = unchecked((int)0x88982F49),
        WINCODEC_ERR_COMPONENTNOTFOUND = unchecked((int)0x88982F50),
        WINCODEC_ERR_IMAGESIZEOUTOFRANGE = unchecked((int)0x88982F51),
        WINCODEC_ERR_TOOMUCHMETADATA = unchecked((int)0x88982F52),
        WINCODEC_ERR_BADIMAGE = unchecked((int)0x88982F60),
        WINCODEC_ERR_BADHEADER = unchecked((int)0x88982F61),
        WINCODEC_ERR_FRAMEMISSING = unchecked((int)0x88982F62),
        WINCODEC_ERR_BADMETADATAHEADER = unchecked((int)0x88982F63),
        WINCODEC_ERR_BADSTREAMDATA = unchecked((int)0x88982F70),
        WINCODEC_ERR_STREAMWRITE = unchecked((int)0x88982F71),
        WINCODEC_ERR_STREAMREAD = unchecked((int)0x88982F72),
        WINCODEC_ERR_STREAMNOTAVAILABLE = unchecked((int)0x88982F73),
        WINCODEC_ERR_UNSUPPORTEDPIXELFORMAT = unchecked((int)0x88982F80),
        WINCODEC_ERR_UNSUPPORTEDOPERATION = unchecked((int)0x88982F81),
        WINCODEC_ERR_INVALIDREGISTRATION = unchecked((int)0x88982F8A),
        WINCODEC_ERR_COMPONENTINITIALIZEFAILURE = unchecked((int)0x88982F8B),
        WINCODEC_ERR_INSUFFICIENTBUFFER = unchecked((int)0x88982F8C),
        WINCODEC_ERR_DUPLICATEMETADATAPRESENT = unchecked((int)0x88982F8D),
        WINCODEC_ERR_PROPERTYUNEXPECTEDTYPE = unchecked((int)0x88982F8E),
        WINCODEC_ERR_UNEXPECTEDSIZE = unchecked((int)0x88982F8F),
        WINCODEC_ERR_INVALIDQUERYREQUEST = unchecked((int)0x88982F90),
        WINCODEC_ERR_UNEXPECTEDMETADATATYPE = unchecked((int)0x88982F91),
        WINCODEC_ERR_REQUESTONLYVALIDATMETADATAROOT = unchecked((int)0x88982F92),
        WINCODEC_ERR_INVALIDQUERYCHARACTER = unchecked((int)0x88982F93),
        WINCODEC_ERR_WIN32ERROR = unchecked((int)0x88982F94),
        WINCODEC_ERR_INVALIDPROGRESSIVELEVEL = unchecked((int)0x88982F95),
        WINCODEC_ERR_INVALIDJPEGSCANINDEX = unchecked((int)0x88982F96),
        D3DERR_BADMAJORVERSION = unchecked((int)0x887602BC),
        D3DERR_BADMINORVERSION = unchecked((int)0x887602BD),
        D3DERR_COLORKEYATTACHED = unchecked((int)0x88760802),
        D3DERR_DEVICEAGGREGATED = unchecked((int)0x887602C3),
        D3DERR_EXECUTE_CLIPPED_FAILED = unchecked((int)0x887602CD),
        D3DERR_EXECUTE_CREATE_FAILED = unchecked((int)0x887602C6),
        D3DERR_EXECUTE_DESTROY_FAILED = unchecked((int)0x887602C7),
        D3DERR_EXECUTE_FAILED = unchecked((int)0x887602CC),
        D3DERR_EXECUTE_LOCK_FAILED = unchecked((int)0x887602C8),
        D3DERR_EXECUTE_LOCKED = unchecked((int)0x887602CA),
        D3DERR_EXECUTE_NOT_LOCKED = unchecked((int)0x887602CB),
        D3DERR_EXECUTE_UNLOCK_FAILED = unchecked((int)0x887602C9),
        D3DERR_INBEGIN = unchecked((int)0x88760302),
        D3DERR_INBEGINSTATEBLOCK = unchecked((int)0x88760835),
        D3DERR_INITFAILED = unchecked((int)0x887602C2),
        D3DERR_INVALID_DEVICE = unchecked((int)0x887602C1),
        D3DERR_INVALIDCURRENTVIEWPORT = unchecked((int)0x887602DF),
        D3DERR_INVALIDMATRIX = unchecked((int)0x88760824),
        D3DERR_INVALIDPALETTE = unchecked((int)0x887602E8),
        D3DERR_INVALIDPRIMITIVETYPE = unchecked((int)0x887602E0),
        D3DERR_INVALIDRAMPTEXTURE = unchecked((int)0x887602E3),
        D3DERR_INVALIDSTATEBLOCK = unchecked((int)0x88760834),
        D3DERR_INVALIDVERTEXFORMAT = unchecked((int)0x88760800),
        D3DERR_INVALIDVERTEXTYPE = unchecked((int)0x887602E1),
        D3DERR_LIGHT_SET_FAILED = unchecked((int)0x887602EE),
        D3DERR_LIGHTHASVIEWPORT = unchecked((int)0x887602EF),
        D3DERR_LIGHTNOTINTHISVIEWPORT = unchecked((int)0x887602F0),
        D3DERR_MATERIAL_CREATE_FAILED = unchecked((int)0x887602E4),
        D3DERR_MATERIAL_DESTROY_FAILED = unchecked((int)0x887602E5),
        D3DERR_MATERIAL_GETDATA_FAILED = unchecked((int)0x887602E7),
        D3DERR_MATERIAL_SETDATA_FAILED = unchecked((int)0x887602E6),
        D3DERR_MATRIX_CREATE_FAILED = unchecked((int)0x887602DA),
        D3DERR_MATRIX_DESTROY_FAILED = unchecked((int)0x887602DB),
        D3DERR_MATRIX_GETDATA_FAILED = unchecked((int)0x887602DD),
        D3DERR_MATRIX_SETDATA_FAILED = unchecked((int)0x887602DC),
        D3DERR_NOCURRENTVIEWPORT = unchecked((int)0x88760307),
        D3DERR_NOTINBEGIN = unchecked((int)0x88760303),
        D3DERR_NOTINBEGINSTATEBLOCK = unchecked((int)0x88760836),
        D3DERR_NOVIEWPORTS = unchecked((int)0x88760304),
        D3DERR_SCENE_BEGIN_FAILED = unchecked((int)0x887602FA),
        D3DERR_SCENE_END_FAILED = unchecked((int)0x887602FB),
        D3DERR_SCENE_IN_SCENE = unchecked((int)0x887602F8),
        D3DERR_SCENE_NOT_IN_SCENE = unchecked((int)0x887602F9),
        D3DERR_SETVIEWPORTDATA_FAILED = unchecked((int)0x887602DE),
        D3DERR_STENCILBUFFER_NOTPRESENT = unchecked((int)0x88760817),
        D3DERR_SURFACENOTINVIDMEM = unchecked((int)0x887602EB),
        D3DERR_TEXTURE_BADSIZE = unchecked((int)0x887602E2),
        D3DERR_TEXTURE_CREATE_FAILED = unchecked((int)0x887602D1),
        D3DERR_TEXTURE_DESTROY_FAILED = unchecked((int)0x887602D2),
        D3DERR_TEXTURE_GETSURF_FAILED = unchecked((int)0x887602D9),
        D3DERR_TEXTURE_LOAD_FAILED = unchecked((int)0x887602D5),
        D3DERR_TEXTURE_LOCK_FAILED = unchecked((int)0x887602D3),
        D3DERR_TEXTURE_LOCKED = unchecked((int)0x887602D7),
        D3DERR_TEXTURE_NO_SUPPORT = unchecked((int)0x887602D0),
        D3DERR_TEXTURE_NOT_LOCKED = unchecked((int)0x887602D8),
        D3DERR_TEXTURE_SWAP_FAILED = unchecked((int)0x887602D6),
        D3DERR_TEXTURE_UNLOCK_FAILED = unchecked((int)0x887602D4),
        D3DERR_TOOMANYPRIMITIVES = unchecked((int)0x88760823),
        D3DERR_TOOMANYVERTICES = unchecked((int)0x88760825),
        D3DERR_VBUF_CREATE_FAILED = unchecked((int)0x8876080D),
        D3DERR_VERTEXBUFFERLOCKED = unchecked((int)0x8876080E),
        D3DERR_VERTEXBUFFEROPTIMIZED = unchecked((int)0x8876080C),
        D3DERR_VERTEXBUFFERUNLOCKFAILED = unchecked((int)0x8876080F),
        D3DERR_VIEWPORTDATANOTSET = unchecked((int)0x88760305),
        D3DERR_VIEWPORTHASNODEVICE = unchecked((int)0x88760306),
        D3DERR_ZBUFF_NEEDS_SYSTEMMEMORY = unchecked((int)0x887602E9),
        D3DERR_ZBUFF_NEEDS_VIDEOMEMORY = unchecked((int)0x887602EA),
        D3DERR_ZBUFFER_NOTPRESENT = unchecked((int)0x88760816),
        D3DERR_CANNOTPROTECTCONTENT = unchecked((int)0x8876087D),
        D3DERR_CONFLICTINGRENDERSTATE = unchecked((int)0x88760821),
        D3DERR_CONFLICTINGTEXTUREFILTER = unchecked((int)0x8876081E),
        D3DERR_CONFLICTINGTEXTUREPALETTE = unchecked((int)0x88760826),
        D3DERR_DEVICEHUNG = unchecked((int)0x88760874),
        D3DERR_DEVICELOST = unchecked((int)0x88760868),
        D3DERR_DEVICENOTRESET = unchecked((int)0x88760869),
        D3DERR_DEVICEREMOVED = unchecked((int)0x88760870),
        D3DERR_DRIVERINTERNALERROR = unchecked((int)0x88760827),
        D3DERR_DRIVERINVALIDCALL = unchecked((int)0x8876086D),
        D3DERR_INVALIDCALL = unchecked((int)0x8876086C),
        D3DERR_INVALIDDEVICE = unchecked((int)0x8876086B),
        D3DERR_MOREDATA = unchecked((int)0x88760867),
        D3DERR_NOTAVAILABLE = unchecked((int)0x8876086A),
        D3DERR_NOTFOUND = unchecked((int)0x88760866),
        D3DERR_OUTOFVIDEOMEMORY = unchecked((int)0x8876017C),
        D3DERR_PRESENT_STATISTICS_DISJOINT = unchecked((int)0x88760884),
        D3DERR_TOOMANYOPERATIONS = unchecked((int)0x8876081D),
        D3DERR_UNSUPPORTEDALPHAARG = unchecked((int)0x8876081C),
        D3DERR_UNSUPPORTEDALPHAOPERATION = unchecked((int)0x8876081B),
        D3DERR_UNSUPPORTEDCOLORARG = unchecked((int)0x8876081A),
        D3DERR_UNSUPPORTEDCOLOROPERATION = unchecked((int)0x88760819),
        D3DERR_UNSUPPORTEDCRYPTO = unchecked((int)0x8876087E),
        D3DERR_UNSUPPORTEDFACTORVALUE = unchecked((int)0x8876081F),
        D3DERR_UNSUPPORTEDOVERLAY = unchecked((int)0x8876087B),
        D3DERR_UNSUPPORTEDOVERLAYFORMAT = unchecked((int)0x8876087C),
        D3DERR_UNSUPPORTEDTEXTUREFILTER = unchecked((int)0x88760822),
        D3DERR_WASSTILLDRAWING = unchecked((int)0x8876021C),
        D3DERR_WRONGTEXTUREFORMAT = unchecked((int)0x88760818),
        D3DERR_COMMAND_UNPARSED = unchecked((int)0x88760BB8),
    }
}