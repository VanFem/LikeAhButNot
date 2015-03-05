using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;

namespace LikeAhButNot.Input
{
    public class KeyUpAction : KeyboardActionBase
    {
        public override string Info
        {
            get { return string.Format("Key {0} up", Enum.GetName(typeof(VirtualKeyCode), KeyCode)); }
        }
        
        public override void DoAction()
        {
            InputSimulator.SimulateKeyUp(KeyCode);
        }
    }
}
