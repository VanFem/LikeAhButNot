using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;

namespace LikeAhButNot.Input
{
    public class KeyUpAction : SequenceAction
    {
        public VirtualKeyCode KeyCode { get; set; }

        public override void DoAction()
        {
            InputSimulator.SimulateKeyUp(KeyCode);
        }
    }
}
