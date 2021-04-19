using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess3
{
    public partial class GameForm : Form
    {
        public List<Label> PlayerNumLabelList { get; set; }
        private Thread runGameThread;
        private Thread runPlayerTurnThread;

        public GameForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            PlayerNumLabelList = new List<Label>()
            {
                player1NumLabel,
                player2NumLabel,
                player3NumLabel,
                player4NumLabel,
                player5NumLabel
            };
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            EndGame();
            initialControlData();
            runGameThread = new Thread(RunGame);
            runGameThread.Start();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (runGameThread != null) runGameThread.Abort();
            if (runPlayerTurnThread != null) runPlayerTurnThread.Abort();
            Program.CurrentFormType = typeof(MenuForm);
            this.Dispose();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            int guessNum = Int32.Parse(PlayerNumLabelList[2].Text);
            if (guessNum %3 == 0 && guessNum != 0 || guessNum.ToString().Contains('3'))
            {
                scoreLabel.Text = (Int32.Parse(scoreLabel.Text) + 10*(int)Program.CurrentGameDifficulty).ToString();
                yesBtn.Enabled = false;
                noBtn.Enabled = false;
                tipLabel.Text = "请等待";
                runPlayerTurnThread.Abort();
            }
            else
            {
                EndGame();
            }
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            int guessNum = Int32.Parse(PlayerNumLabelList[2].Text);
            if (guessNum % 3 != 0 && !guessNum.ToString().Contains('3'))
            {
                scoreLabel.Text = (Int32.Parse(scoreLabel.Text) + 10 * (int)Program.CurrentGameDifficulty).ToString();
                yesBtn.Enabled = false;
                noBtn.Enabled = false;
                tipLabel.Text = "请等待";
                runPlayerTurnThread.Abort();
            }
            else 
            {
                EndGame();
            }
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.CurrentFormType = null;
        }

        private void initialControlData()
        {
            scoreLabel.Text = "0";
            countDownLabel.Text = "0";
            tipLabel.Text = "请等待";
            yesBtn.Enabled = false;
            noBtn.Enabled = false;
            foreach (Label playerNumLabel in PlayerNumLabelList)
            {
                playerNumLabel.Text = "0";
                playerNumLabel.ForeColor = Control.DefaultForeColor;
            }
        }

        private void RunGame()
        {
            int guessNum = new Random().Next(10, 100);
            int currentPlayerIndex = 0;
            int prePlayerIndex = 0;
            while (true)
            {
                PlayerNumLabelList[prePlayerIndex].ForeColor = Color.Black;
                PlayerNumLabelList[currentPlayerIndex].ForeColor = Color.Red;
                PlayerNumLabelList[currentPlayerIndex].Text = guessNum.ToString();
                Refresh();
                if (currentPlayerIndex == 2)
                {
                    runPlayerTurnThread = new Thread(RunPlayerTurn);
                    runPlayerTurnThread.Start();
                    runPlayerTurnThread.Join();
                }
                guessNum = guessNum + 1;
                currentPlayerIndex = currentPlayerIndex>=4? 0: currentPlayerIndex+1;
                prePlayerIndex = currentPlayerIndex == 0 ? 4 : currentPlayerIndex-1;
                Thread.Sleep(250);
            }
        }

        private void RunPlayerTurn()
        {
            yesBtn.Enabled = true;
            noBtn.Enabled = true;
            tipLabel.Text="到你了";
            int countTime=0;
            if (Program.CurrentGameDifficulty == GameDifficulty.easy) 
            {
                countTime = 5;
            }
            else if(Program.CurrentGameDifficulty == GameDifficulty.normal)
            {
                countTime = 3;
            }
            else if(Program.CurrentGameDifficulty == GameDifficulty.hard) 
            {
                countTime = 1;
            }
            for (; countTime >= 0; countTime--)
            {
                countDownLabel.Text = countTime.ToString();
                Refresh();
                Thread.Sleep(1000);
            }
            EndGame();
        }

        private void EndGame() 
        {
            if (runGameThread != null) runGameThread.Abort();
            if (runPlayerTurnThread != null) runPlayerTurnThread.Abort();
            yesBtn.Enabled = false;
            noBtn.Enabled = false;
            tipLabel.Text= "游戏结束";
            Program.Top10PlayerList.Add(new Player(Program.CurrentPlayerName,Int32.Parse(scoreLabel.Text)));
            Program.Top10PlayerList.Sort((Player player1,Player player2)=> 
            {
                return player2.Score.CompareTo(player1.Score);
            });
            Program.Top10PlayerList.RemoveAt(Program.Top10PlayerList.Count-1);
        }

    }
}