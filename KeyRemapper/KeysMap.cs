using System.Collections.Generic;
using HookCore.Models;

namespace KeyRemapper
{
    public class KeysMap
    {
        public Dictionary<Key, string> Map { get; } = new Dictionary<Key, string>()
        {
            { Key.None, "" },
            { Key.Space, " " },
            { Key.RMenu, "" },
            { Key.LMenu, "" },
            { Key.RShiftKey, "" },
        };

        public string this[Key key]
        {
            get
            {
                if (Map.ContainsKey(key))
                    return Map[key];
                return null;
            }
        }
    }
}
