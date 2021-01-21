using KeyHookCore.Interfaces;

namespace KeyHookCore.Models
{
    public class KeyboardHook : Hook
    {
        public int Code { get; set; }
        public int WParam { get; set; }
        public KeyboardHookData LParam { get; set; }

        public KeyboardHook(int code, int wParam, KeyboardHookData lParam)
        {
            Code = code;
            WParam = wParam;
            LParam = lParam;
        }
    }
}
