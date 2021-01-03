using System.Collections.Generic;
using System.Windows.Forms;

namespace KeyRemapper
{
    public class KeysMap
    {
        public Dictionary<Keys, string> Map { get; } = new Dictionary<Keys, string>()
        {
            { Keys.None, "" },
            { Keys.Space, " " },
            { Keys.RMenu, "" },
            { Keys.LMenu, "" },
            { Keys.RShiftKey, "" },
        };

        public string this[Keys key]
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
