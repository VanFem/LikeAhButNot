using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace LikeAhButNot.Input
{
    public class MouseDownAction : SequenceAction
    {
        public int Button { get; set; }

        public override void DoAction()
        {
        }
    }
}
