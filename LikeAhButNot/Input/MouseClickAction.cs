using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;

namespace LikeAhButNot.Input
{
    public class MouseClickAction : MouseActionBase
    {
        public override string Info
        {
            get { return string.Format("{1}Click mouse {0}", Enum.GetName(typeof(MouseButtonType), Button),MoveMouse?MoveInfo+"; ":""); }
        }

        public override void DoAction()
        {
            base.DoAction();
            
        }
    }
}
