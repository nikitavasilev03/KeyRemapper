namespace HookCore.Models
{
    public class KeyHook : Hook
    {
        public Key Key { get; set; }
        public bool IsDown { get; set; }

        public KeyHook(Key key, bool isDown)
        {
            Key = key;
            IsDown = isDown;
        }
    }
}
