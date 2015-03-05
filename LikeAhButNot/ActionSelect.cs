using System;
using System.Windows.Forms;
using WindowsInput;
using LikeAhButNot.Input;

namespace LikeAhButNot
{
    public partial class ActionSelect : Form
    {
        private enum SetupGroup
        {
            KeyboardSetup,
            MouseSetup,
            DelaySetup
        }

        public SequenceAction SetAction { get; set; }

        public ActionSelect()
        {
            InitializeComponent();
            cmbVKC.DataSource = Enum.GetValues(typeof (VirtualKeyCode));
            cmbMouseClickType
            radKeyboardGroup.Checked = true;
            SetActiveGroup(SetupGroup.KeyboardSetup);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ReadMouseAction()
        {
            MouseActionBase action;
            if (radMouseClick.Checked)
            {
                action = new MouseClickAction();
            }
            else if (radMouseDown.Checked)
            {
                action = new MouseDownAction();
            }
            else if (radMouseUp.Checked)
            {
                action = new MouseUpAction();
            }
            else
            {
                throw new ArgumentException("Mouse event type could not be determined.");
            }

            action.MoveMouse = chkMoveMouse.Checked;
            action.MoveX = (int) numMouseMoveX.Value;
            action.MoveY = (int) numMouseMoveY.Value;
            action.Button = cmbMouseClickType.SelectedIndex;
        }

        private void SetActiveGroup(SetupGroup group)
        {
            grpDelay.Enabled = false;
            grpKeyboard.Enabled = false;
            grpMouse.Enabled = false;

            switch (group)
            {
                case SetupGroup.KeyboardSetup:
                    grpKeyboard.Enabled = true;
                    break;
                case SetupGroup.MouseSetup:
                    grpMouse.Enabled = true;
                    break;
                case SetupGroup.DelaySetup:
                    grpDelay.Enabled = true;
                    break;
            }
        }

        private void radKeyboardGroup_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                SetActiveGroup(SetupGroup.KeyboardSetup);
            }
        }

        private void radMouseGroup_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                SetActiveGroup(SetupGroup.MouseSetup);
            }
        }

        private void radDelay_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                SetActiveGroup(SetupGroup.DelaySetup);
            }
        }
    }
}
    