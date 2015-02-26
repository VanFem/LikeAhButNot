using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LikeAhButNot.Input
{
    public class DelayAction : SequenceAction
    {
        public int DelayTime { get; set; }

        public override void DoAction()
        {
            Thread.Sleep(DelayTime);
        }
    }
}
