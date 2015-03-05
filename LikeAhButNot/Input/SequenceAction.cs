using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace LikeAhButNot.Input
{
    public class SequenceAction
    {
        public SequenceAction NextAction { get; set; }

        public virtual string Type
        {
            get { throw new NotImplementedException(); }
        }

        public virtual string Info
        {
            get { throw new NotImplementedException(); }
        }


        public virtual void DoAction()
        {
        }

        public void Act()
        {
            DoAction();
            if (NextAction != null)
                NextAction.Act();
        }
    }
}
