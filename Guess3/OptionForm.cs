using System;
using System.Drawing;
using System.Windows.Forms;

namespace Guess3
{
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {
            ChangeDifficulty(Program.CurrentGameDifficulty);
            ChangePlayerName(Program.CurrentPlayerName);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Program.CurrentFormType = typeof(MenuForm);
            this.Dispose();
        }

        private void OptionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.CurrentFormType = null;
        }

        private void easyBtn_Click(object sender, EventArgs e)
        {
            ChangeDifficulty(GameDifficulty.easy);
        }

        private void normalBtn_Click(object sender, EventArgs e)
        {
            ChangeDifficulty(GameDifficulty.normal);
        }

        private void hardBtn_Click(object sender, EventArgs e)
        {
            ChangeDifficulty(GameDifficulty.hard);
        }

        private void ChangeDifficulty(GameDifficulty gameDifficulty)
        {
            easyBtn.BackColor = DefaultBackColor;
            normalBtn.BackColor = DefaultBackColor;
            hardBtn.BackColor = DefaultBackColor;
            Program.CurrentGameDifficulty = gameDifficulty;
            if (Program.CurrentGameDifficulty == GameDifficulty.easy)
            {
                easyBtn.BackColor = Color.SpringGreen;
            }
            else if (Program.CurrentGameDifficulty == GameDifficulty.normal)
            {
                normalBtn.BackColor = Color.SpringGreen;
            }
            else if (Program.CurrentGameDifficulty == GameDifficulty.hard)
            {
                hardBtn.BackColor = Color.SpringGreen;
            }
            this.Refresh();
        }

        private void ChangePlayerName(string playerName) 
        {
            Program.CurrentPlayerName = playerName;
            playerNameTextBox.Text = playerName;
        }

        private void playerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ChangePlayerName(playerNameTextBox.Text);
        }
    }
}
