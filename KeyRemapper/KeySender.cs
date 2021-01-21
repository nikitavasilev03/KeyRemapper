using System.Windows.Forms;
using HookCore.Models;
using KeyRemapperCore.Interfaces;

namespace KeyRemapper
{
    public class KeySender : IKeySender
    {
        public KeysMap Map { get; }

        public KeySender(KeysMap map)
        {
            Map = map;
        }
        public void Send(Key key)
        {
            SendKeys.Send(Map[key]);
        }
    }
}
