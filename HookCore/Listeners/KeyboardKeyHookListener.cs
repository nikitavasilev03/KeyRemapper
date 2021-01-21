using System;
using HookCore.Models;
using KeyHookCore.Interfaces;

namespace HookCore.Listeners
{
    public class KeyboardKeyHookListener : IListenerHook
    {
        private readonly IListenerHook listenerHook;

        public Func<Hook, HookResult> HandleHook { get; set; }
        public bool Hooked => listenerHook.Hooked;

        public KeyboardKeyHookListener()
        {
            listenerHook = new KeyboardHookListener
            {
                HandleHook = ListenHook,
            };
        }

        private HookResult ListenHook(Hook hook)
        {
            var kh = (KeyboardHook)hook;
            
            Key key = (Key)kh.LParam.vkCode;
            int wParam = kh.WParam;
            bool isDown = wParam == KeyboardHookListener.WM_KEYDOWN || wParam == KeyboardHookListener.WM_SYSKEYDOWN;

            if (HandleHook != null)
                return HandleHook.Invoke(new KeyHook(key, isDown));
            return HookResult.Release;
        }

        public void Hook()
        {
            listenerHook.Hook();
        }

        public void Unhook()
        {
            listenerHook.Unhook();
        }
    }
}
