using System;
using HookCore.Models;

namespace KeyRemapperCore
{
    [Serializable]
    public class KeysRule
    {
        public Key KeyPress { get; }
        public Key KeySend { get; }

        public KeysRule(Key keyPress, Key keySend)
        {
            KeyPress = keyPress;
            KeySend = keySend;
        }

        public override string ToString()
        {
            return $"{KeyPress} -> {KeySend}";
        }

        public override bool Equals(object obj)
        {
            var keysRule = obj as KeysRule;
            if (keysRule == null)
                return false;
            if (keysRule.KeyPress == KeyPress && keysRule.KeySend == KeySend)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return (int)KeyPress * 1000000 + (int)KeySend;
        }
    }
}
