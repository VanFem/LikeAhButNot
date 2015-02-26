using System.Collections.Generic;
using System.Windows.Forms;
using LikeAhButNot.Input;

namespace LikeAhButNot
{
    public partial class LikeAhButNotMainForm : Form
    {
        private List<SequenceAction> ActionList = new List<SequenceAction>();


        public LikeAhButNotMainForm()
        {
            InitializeComponent();
            sequenceActionBindingSource.DataSource = ActionList;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            using (var addWindow = new ActionSelect())
            {
                if (addWindow.ShowDialog() == DialogResult.OK)
                {
                    ActionList.Add(addWindow.SetAction);
                    sequenceActionBindingSource.ResetBindings(false);
                }
            }
        }
    }
}
