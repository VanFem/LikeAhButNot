using System;
using System.Windows.Forms;
using WindowsInput;
using LikeAhButNot.Input;

namespace LikeAhButNot
{
    public partial class ActionSelect : Form
    {
        public SequenceAction SetAction { get; set; }

        public ActionSelect()
        {
            InitializeComponent();
            cmbVKC.DataSource = Enum.GetValues(typeof (VirtualKeyCode));
            SetAction = new KeyPressAction() {Info = "lalala", Type = "Kbd"};
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
