using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeAhButNot.Input
{
    public class SequenceAction
    {
        public SequenceAction NextAction { get; set; }

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
