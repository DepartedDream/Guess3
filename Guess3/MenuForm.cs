using System;
using System.Windows.Forms;

namespace Guess3
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            Program.CurrentFormType=typeof(GameForm);
            this.Dispose();
        }

        private void rankBtn_Click(object sender, EventArgs e)
        {
            Program.CurrentFormType = typeof(RankForm);
            this.Dispose();
        }

        private void optionBtn_Click(object sender, EventArgs e)
        {
            Program.CurrentFormType = typeof(OptionForm);
            this.Dispose();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.CurrentFormType = null;
        }

    }
}
