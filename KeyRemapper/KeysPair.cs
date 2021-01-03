using System.Windows.Forms;

namespace KeyRemapper
{
    public class KeysPair
    {
        public Keys KeyPress { get; }
        public Keys KeySend { get; }

        public KeysPair(Keys keyPress, Keys keySend)
        {
            KeyPress = keyPress;
            KeySend = keySend;
        }
    }
}
