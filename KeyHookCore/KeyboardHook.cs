using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KeyHookCore
{
    public enum HookResult
    {
        Release,
        NoRelease
    }

    public delegate int KeyboardHookProc(int code, int wParam, ref KeyboardHookData lParam);
    public delegate void KeyboardHookEvent(int wParam, KeyboardHookData lParam);

    public class KeyboardHook
    {
        //#############################################################       
        #region [# Win32 Constants #]

        public static readonly int WH_KEYBOARD_LL = 13;
        public static readonly int WM_KEYDOWN = 0x100;
        public static readonly int WM_KEYUP = 0x101;
        public static readonly int WM_SYSKEYDOWN = 0x104;
        public static readonly int WM_SYSKEYUP = 0x105;

        //public static IntPtr hInstance = LoadLibrary("User32");

        #endregion
        //#############################################################
        #region [# Properties #]

        protected IntPtr hhook = IntPtr.Zero;
        protected KeyboardHookProc hookDelegate;

        #endregion
        //#############################################################  
        #region [# Flags #]        

        public bool Hooked => bHooked;
        private volatile bool bHooked = false;
        public bool LeftShiftHeld => bLeftShiftHeld;
        private volatile bool bLeftShiftHeld = false;
        public bool RightShiftHeld => bRightShiftHeld;
        private volatile bool bRightShiftHeld = false;
        public bool ShiftHeld => bShiftHeld;
        private volatile bool bShiftHeld = false;
        public bool AltHeld => bAltHeld;
        private volatile bool bAltHeld = false;
        public bool CtrlHeld => bCtrlHeld;
        private volatile bool bCtrlHeld = false;

        #endregion
        //#############################################################
        #region [# Events #]

        public event KeyboardHookEvent KeyDown;

        public event KeyboardHookEvent KeyUp;

        #endregion
        //#############################################################
        #region [# Construction / Destruction #]

        public KeyboardHook() {}

        ~KeyboardHook() { Unhook(); }

        #endregion   
        //#############################################################
        #region [# Hooks #]

        public virtual void Hook()
        {
            hookDelegate = _hookProc;
            //Get library instance
            IntPtr hInstance = LoadLibrary("User32");
            //Call library hook function
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, hookDelegate, hInstance, 0);
            //Set bHooked to true if successful.
            bHooked = (hhook != null);
        }

        public virtual void Unhook()
        {
            //Call library unhook function
            UnhookWindowsHookEx(hhook);
            bHooked = false;
        }

        private int _hookProc(int code, int wParam, ref KeyboardHookData lParam)
        {
            HookResult result = HookResult.NoRelease;
            if (code >= 0)
                 result = HookProc(code, wParam, ref lParam);
            switch (result)
            {
                case HookResult.NoRelease:
                    return 1;
                case HookResult.Release:
                    return CallNextHookEx(hhook, code, wParam, ref lParam); ;
                default:
                    return CallNextHookEx(hhook, code, wParam, ref lParam); ;
            }
        }

        protected virtual HookResult HookProc(int code, int wParam, ref KeyboardHookData lParam)
        {
            Keys k = (Keys)lParam.vkCode;

            //Check for shift(s), alt, and ctrl.
            //Shift
            if (k == Keys.LShiftKey)
                bLeftShiftHeld = bShiftHeld = (wParam == WM_KEYDOWN);
            else if (k == Keys.RShiftKey)
                bRightShiftHeld = bShiftHeld = (wParam == WM_KEYDOWN);
            //Control
            if ((lParam.vkCode & 0xA2) == 0xA2 || (lParam.vkCode & 0xA3) == 0xA3)
            {
                bCtrlHeld = (wParam == WM_KEYDOWN);
                return HookResult.NoRelease;
            }
            //Alt
            if ((lParam.vkCode & 0xA4) == 0xA4 || (lParam.vkCode & 0xA5) == 0xA5)
            {
                bAltHeld = (wParam == WM_KEYDOWN);
                return HookResult.NoRelease;
            }

            if (wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN)
            {
                KeyDown?.Invoke(wParam, lParam);
            }
            else if (wParam == WM_KEYUP || wParam == WM_SYSKEYUP)
            {
                KeyUp?.Invoke(wParam, lParam);
            }

            return HookResult.Release;
        }

        #endregion
        //#############################################################
        #region [# DLL Imports #]

        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, KeyboardHookProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern int CallNextHookEx(IntPtr idHook, int nCode, int wParam, ref KeyboardHookData lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        #endregion
    }
}