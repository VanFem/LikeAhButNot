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

        public override string Info
        {
            get { return string.Format("Wait for {0}ms", DelayTime); }
        }

        public override string Type
        {
            get { return "Delay"; }
        }
        public override void DoAction()
        {
            Thread.Sleep(DelayTime);
        }
    }
}
