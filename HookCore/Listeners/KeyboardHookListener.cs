using System;
using System.Runtime.InteropServices;
using HookCore.Models;
using KeyHookCore;
using KeyHookCore.Interfaces;

namespace HookCore.Listeners
{
    public delegate int KeyboardHookProc(int code, int wParam, ref KeyboardHookData lParam);
    public delegate void KeyboardHookEvent(int wParam, KeyboardHookData lParam);

    public class KeyboardHookListener : IListenerHook
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

        public Func<Hook, HookResult> HandleHook { get; set; }
        #endregion
        //#############################################################
        #region [# Events #]

        public event KeyboardHookEvent KeyDown;

        public event KeyboardHookEvent KeyUp;

        #endregion
        //#############################################################
        #region [# Construction / Destruction #]

        public KeyboardHookListener()
        {
            HandleHook = HookProc;
        }

        ~KeyboardHookListener() { Unhook(); }

        #endregion   
        //#############################################################
        #region [# Hooks #]

        public void Hook()
        {
            hookDelegate = _hookProc;
            //Get library instance
            IntPtr hInstance = LoadLibrary("User32");
            //Call library hook function
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, hookDelegate, hInstance, 0);
            //Set bHooked to true if successful.
            bHooked = (hhook != null);
        }

        public void Unhook()
        {
            //Call library unhook function
            if (bHooked)
                UnhookWindowsHookEx(hhook);
            bHooked = false;
        }

        private int _hookProc(int code, int wParam, ref KeyboardHookData lParam)
        {
            HookResult result = HookResult.NoRelease;
            if (code >= 0 && HandleHook != null)
                 result = HandleHook.Invoke(new KeyboardHook(code, wParam, lParam));
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

        private HookResult HookProc(Hook hook)
        {
            var kh = (KeyboardHook)hook;
            var code = kh.Code;
            var wParam = kh.WParam;
            var lParam = kh.LParam;

            Key k = (Key)lParam.vkCode;

            //Check for shift(s), alt, and ctrl.
            //Shift
            if (k == Key.LShiftKey)
                bLeftShiftHeld = bShiftHeld = (wParam == WM_KEYDOWN);
            else if (k == Key.RShiftKey)
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