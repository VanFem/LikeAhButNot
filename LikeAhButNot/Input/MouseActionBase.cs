﻿using WindowsInput;

namespace LikeAhButNot.Input
{
    public class MouseActionBase : SequenceAction
    {
        public MouseButtonType Button { get; set; }

        public bool MoveMouse { get; set; }
        public int MoveX { get; set; }
        public int MoveY { get; set; }

        public override string Type
        {
            get { return "Mouse"; }
        }

        public override void DoAction()
        {
        }
    }
}