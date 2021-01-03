using System;
using System.Windows.Forms;

namespace KeyHookCore
{
    public delegate void KeyboardKeyEvent(KeyEventArgs args);
    public class KeyboardKeyHook : KeyboardHook
    {
        public event KeyboardKeyEvent KeyPress;
        public Func<Keys, HookResult> ManageHook { get; set; }

        protected override HookResult HookProc(int code, int wParam, ref KeyboardHookData lParam)
        {
            Keys key = (Keys)lParam.vkCode;

            //Key Press Event        
            KeyEventArgs keyEvent = new KeyEventArgs(key);
            if (wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN)
            {
                KeyPress?.Invoke(keyEvent);
                if (ManageHook != null)
                    return ManageHook.Invoke(key);
            }
            return HookResult.Release;
        }
    }
}
