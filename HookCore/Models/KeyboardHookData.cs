﻿using System;

namespace HookCore.Models
{
    [Serializable]
    public struct KeyboardHookData
    {
        public int vkCode;
        public int scanCode;
        public int flags;
        public int time;
        public int dwExtraInfo;
    }
}
