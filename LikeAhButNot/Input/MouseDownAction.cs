using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace LikeAhButNot.Input
{
    public class MouseDownAction : MouseActionBase
    {
        public override string Info
        {
            get { return string.Format("Mouse {0} down", Enum.GetName(typeof(MouseButtonType), Button)); }
        }

        public override void DoAction()
        {
        }
    }
}
