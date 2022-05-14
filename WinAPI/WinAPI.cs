using System;
using System.Runtime.InteropServices;

namespace DirectDimensional.Bindings.WinAPI {
    internal delegate nint WndProc(IntPtr hwnd, WindowMessages msg, nuint wParam, nint lParam);

    internal static unsafe class WinAPI {
        public static POINTS MakePOINTS(nint lParam) {
            return *(POINTS*)&lParam;
        }

        public static ushort HIWORD(int input) {
            return (ushort)((input >> 16) & 0xFFFF);
        }

        public static ushort LOWORD(int input) {
            return (ushort)(input & 0xFFFF);
        }

        [DllImport("User32.dll", ExactSpelling = true)]
        public static extern void RegisterClassExW(ref WNDCLASSEXW wndClass);
        [DllImport("User32.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        public static extern void UnregisterClassW(string className, IntPtr hInstance);
        [DllImport("User32.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr CreateWindowExW(uint exStyle, string className, string windowName, uint style, int x, int y, int width, int height, IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lpParam);
        [DllImport("User32.dll", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowWindow(IntPtr hWnd, int show);
        [DllImport("User32.dll", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekMessageW(out MSG message, IntPtr hwnd, uint msgFilterMin, uint msgFilterMax, uint removeMsg);
        [DllImport("User32.dll", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool TranslateMessage(ref MSG message);
        [DllImport("User32.dll", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DispatchMessageW(ref MSG message);
        [DllImport("User32.dll", ExactSpelling = true)]
        public static extern nint DefWindowProcW(IntPtr hwnd, WindowMessages msg, nuint wParam, nint lParam);
        [DllImport("User32.dll", ExactSpelling = true)]
        public static extern void PostQuitMessage(int code);
        [DllImport("User32.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr LoadCursorW(IntPtr hwnd, StandardCursorID cursorID);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        public static extern void RtlZeroMemory(IntPtr dst, nuint length);

        [DllImport("User32.dll", ExactSpelling = true)]
        public static extern IntPtr SetCapture(IntPtr hwnd);
        [DllImport("User32.dll", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hwnd);

        [DllImport("User32.dll", ExactSpelling = true)]
        public static extern int MapWindowPoints(IntPtr hwndFrom, IntPtr hwndTo, POINT* points, int pointCount);

        [DllImport("kernel32.dll", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryPerformanceFrequency(out long frequency);
        [DllImport("kernel32.dll", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool QueryPerformanceCounter(out long frequency);

        [DllImport("Ole32.dll", ExactSpelling = true)]
        public static extern HRESULT CoCreateInstance([MarshalAs(UnmanagedType.LPStruct)] Guid rclsid, object? pUnkOuter, ushort dwClsContext, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, out IntPtr output);

        [DllImport("User32.dll", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClientRect(IntPtr hwnd, out RECT rect);

        [DllImport("User32.dll", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT rect);

        [DllImport("User32.dll", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ClientToScreen(IntPtr hwnd, ref POINT point);

        [DllImport("User32.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        public static extern int MessageBoxW(IntPtr hwnd, string text, string caption, uint type);
        
        [DllImport("User32.dll", ExactSpelling = true)]
        public static extern IntPtr SetCursor(IntPtr pCursor);

        [DllImport("User32.dll", ExactSpelling = true)]
        public static extern int GetSystemMetric(SystemMetric metric);

        [DllImport("User32.dll", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterRawInputDevices(RAWINPUTDEVICE* prid, uint numDevices, uint cbSize);

        [DllImport("User32.dll", ExactSpelling = true)]
        public static extern uint GetRawInputData(RAWINPUT* pRawInput, uint command, void* pData, ref uint cbSize, int cbSizeHeader);

        [DllImport("User32.dll", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorPos(out POINT pt);

        [DllImport("User32.dll", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetCursorPos(int x, int y);
    }
}
