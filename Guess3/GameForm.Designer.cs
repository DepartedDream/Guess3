
namespace Guess3
{
    partial class GameForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.describeLabel2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.describeLabel3 = new System.Windows.Forms.Label();
            this.countDownLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.playerNumListPanel = new System.Windows.Forms.Panel();
            this.player1NumLabel = new System.Windows.Forms.Label();
            this.player5NumLabel = new System.Windows.Forms.Label();
            this.player2NumLabel = new System.Windows.Forms.Label();
            this.player4NumLabel = new System.Windows.Forms.Label();
            this.player3NumLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.noBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.yesBtn = new System.Windows.Forms.Button();
            this.tipLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.playerNumListPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.playerNumListPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.scoreLabel);
            this.panel1.Controls.Add(this.describeLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(395, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 181);
            this.panel1.TabIndex = 12;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scoreLabel.Location = new System.Drawing.Point(167, 79);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(65, 75);
            this.scoreLabel.TabIndex = 12;
            this.scoreLabel.Text = "0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // describeLabel2
            // 
            this.describeLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.describeLabel2.AutoSize = true;
            this.describeLabel2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.describeLabel2.Location = new System.Drawing.Point(169, 50);
            this.describeLabel2.Name = "describeLabel2";
            this.describeLabel2.Size = new System.Drawing.Size(63, 25);
            this.describeLabel2.TabIndex = 13;
            this.describeLabel2.Text = "Score";
            this.describeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.describeLabel3);
            this.panel2.Controls.Add(this.countDownLabel);
            this.panel2.Controls.Add(this.backBtn);
            this.panel2.Controls.Add(this.startBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 181);
            this.panel2.TabIndex = 13;
            // 
            // describeLabel3
            // 
            this.describeLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.describeLabel3.AutoSize = true;
            this.describeLabel3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.describeLabel3.Location = new System.Drawing.Point(138, 45);
            this.describeLabel3.Name = "describeLabel3";
            this.describeLabel3.Size = new System.Drawing.Size(118, 25);
            this.describeLabel3.TabIndex = 20;
            this.describeLabel3.Text = "countDown";
            this.describeLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countDownLabel
            // 
            this.countDownLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countDownLabel.AutoSize = true;
            this.countDownLabel.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.countDownLabel.Location = new System.Drawing.Point(162, 79);
            this.countDownLabel.Name = "countDownLabel";
            this.countDownLabel.Size = new System.Drawing.Size(65, 75);
            this.countDownLabel.TabIndex = 19;
            this.countDownLabel.Text = "5";
            this.countDownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.backBtn.Location = new System.Drawing.Point(9, 9);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(80, 30);
            this.backBtn.TabIndex = 16;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startBtn.Location = new System.Drawing.Point(9, 45);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(80, 30);
            this.startBtn.TabIndex = 18;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // playerNumListPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.playerNumListPanel, 2);
            this.playerNumListPanel.Controls.Add(this.tipLabel);
            this.playerNumListPanel.Controls.Add(this.player1NumLabel);
            this.playerNumListPanel.Controls.Add(this.player5NumLabel);
            this.playerNumListPanel.Controls.Add(this.player2NumLabel);
            this.playerNumListPanel.Controls.Add(this.player4NumLabel);
            this.playerNumListPanel.Controls.Add(this.player3NumLabel);
            this.playerNumListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerNumListPanel.Location = new System.Drawing.Point(2, 189);
            this.playerNumListPanel.Margin = new System.Windows.Forms.Padding(2);
            this.playerNumListPanel.Name = "playerNumListPanel";
            this.playerNumListPanel.Size = new System.Drawing.Size(780, 182);
            this.playerNumListPanel.TabIndex = 10;
            // 
            // player1NumLabel
            // 
            this.player1NumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.player1NumLabel.AutoSize = true;
            this.player1NumLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.player1NumLabel.Location = new System.Drawing.Point(64, 80);
            this.player1NumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player1NumLabel.Name = "player1NumLabel";
            this.player1NumLabel.Size = new System.Drawing.Size(24, 27);
            this.player1NumLabel.TabIndex = 5;
            this.player1NumLabel.Text = "0";
            this.player1NumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player5NumLabel
            // 
            this.player5NumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.player5NumLabel.AutoSize = true;
            this.player5NumLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.player5NumLabel.Location = new System.Drawing.Point(667, 82);
            this.player5NumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player5NumLabel.Name = "player5NumLabel";
            this.player5NumLabel.Size = new System.Drawing.Size(23, 25);
            this.player5NumLabel.TabIndex = 9;
            this.player5NumLabel.Text = "0";
            this.player5NumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2NumLabel
            // 
            this.player2NumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.player2NumLabel.AutoSize = true;
            this.player2NumLabel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.player2NumLabel.Location = new System.Drawing.Point(187, 82);
            this.player2NumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player2NumLabel.Name = "player2NumLabel";
            this.player2NumLabel.Size = new System.Drawing.Size(24, 27);
            this.player2NumLabel.TabIndex = 6;
            this.player2NumLabel.Text = "0";
            this.player2NumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player4NumLabel
            // 
            this.player4NumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.player4NumLabel.AutoSize = true;
            this.player4NumLabel.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.player4NumLabel.Location = new System.Drawing.Point(568, 82);
            this.player4NumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player4NumLabel.Name = "player4NumLabel";
            this.player4NumLabel.Size = new System.Drawing.Size(23, 25);
            this.player4NumLabel.TabIndex = 8;
            this.player4NumLabel.Text = "0";
            this.player4NumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player3NumLabel
            // 
            this.player3NumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.player3NumLabel.AutoSize = true;
            this.player3NumLabel.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.player3NumLabel.Location = new System.Drawing.Point(359, 57);
            this.player3NumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player3NumLabel.Name = "player3NumLabel";
            this.player3NumLabel.Size = new System.Drawing.Size(65, 75);
            this.player3NumLabel.TabIndex = 7;
            this.player3NumLabel.Text = "0";
            this.player3NumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.noBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(395, 376);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 182);
            this.panel4.TabIndex = 15;
            // 
            // noBtn
            // 
            this.noBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noBtn.Enabled = false;
            this.noBtn.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.noBtn.Location = new System.Drawing.Point(0, 0);
            this.noBtn.Margin = new System.Windows.Forms.Padding(2);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(386, 182);
            this.noBtn.TabIndex = 11;
            this.noBtn.Text = "no";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.yesBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 376);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 182);
            this.panel3.TabIndex = 16;
            // 
            // yesBtn
            // 
            this.yesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yesBtn.Enabled = false;
            this.yesBtn.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yesBtn.Location = new System.Drawing.Point(0, 0);
            this.yesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(386, 182);
            this.yesBtn.TabIndex = 10;
            this.yesBtn.Text = "yes";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // tipLabel
            // 
            this.tipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tipLabel.AutoSize = true;
            this.tipLabel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tipLabel.Location = new System.Drawing.Point(367, 21);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(50, 25);
            this.tipLabel.TabIndex = 10;
            this.tipLabel.Text = "提示";
            this.tipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.playerNumListPanel.ResumeLayout(false);
            this.playerNumListPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel playerNumListPanel;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Label player1NumLabel;
        private System.Windows.Forms.Label player5NumLabel;
        private System.Windows.Forms.Label player2NumLabel;
        private System.Windows.Forms.Label player4NumLabel;
        private System.Windows.Forms.Label player3NumLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label describeLabel2;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label describeLabel3;
        private System.Windows.Forms.Label countDownLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label tipLabel;
    }
}

