﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;

namespace LikeAhButNot.Input
{
    public class KeyDownAction : KeyboardActionBase
    {
        public override string Info
        {
            get { return string.Format("Key {0} down", Enum.GetName(typeof(VirtualKeyCode), KeyCode)); }
        }

        public override void DoAction()
        {
            InputSimulator.SimulateKeyDown(KeyCode);
        }
    }
}
