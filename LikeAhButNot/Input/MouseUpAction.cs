using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;

namespace LikeAhButNot.Input
{
    public class MouseUpAction : MouseActionBase
    {
        public override string Info
        {
            get { return string.Format("{1}Mouse {0} down", Enum.GetName(typeof(MouseButtonType), Button), MoveMouse ? MoveInfo + "; " : ""); }
        }
        
        public override void DoAction()
        {
        }
    }
}
