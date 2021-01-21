using KeyHookCore.Models;
using System;

namespace KeyHookCore.Interfaces
{
    public interface IListenerHook
    {
        Func<Hook, HookResult> HandleHook { get; set; }
        
        void Hook();
        void Unhook();
    }
}
