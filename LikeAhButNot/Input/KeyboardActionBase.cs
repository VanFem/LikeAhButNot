using WindowsInput;

namespace LikeAhButNot.Input
{
    public class KeyboardActionBase : SequenceAction
    {
        public VirtualKeyCode KeyCode { get; set; }

        public override string Type
        {
            get { return "Keyboard"; }
        }
    }
}