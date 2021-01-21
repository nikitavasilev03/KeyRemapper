using System;
using HookCore.Models;

namespace KeyHookCore.Interfaces
{
    public interface IListenerHook
    {
        Func<Hook, HookResult> HandleHook { get; set; }
        bool Hooked { get; }
        void Hook();
        void Unhook();
    }
}
