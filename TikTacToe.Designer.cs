namespace TicTacToe
{
    partial class TikTacToe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            button0 = new Button();
            button1 = new Button();
            button4 = new Button();
            button7 = new Button();
            button3 = new Button();
            button2 = new Button();
            button8 = new Button();
            button5 = new Button();
            button6 = new Button();
            turnLabel = new Label();
            computerWins = new Label();
            playerWins = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 1, 0, 1);
            menuStrip1.Size = new Size(317, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { optionsToolStripMenuItem, resetToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(116, 22);
            optionsToolStripMenuItem.Text = "Options";
            optionsToolStripMenuItem.Click += Menu_Options_Click;
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(116, 22);
            resetToolStripMenuItem.Text = "Reset";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += Menu_Exit_Click;
            // 
            // button0
            // 
            button0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button0.Location = new Point(61, 74);
            button0.Margin = new Padding(2);
            button0.Name = "button0";
            button0.Size = new Size(58, 21);
            button0.TabIndex = 1;
            button0.UseVisualStyleBackColor = true;
            button0.Click += BoardButton_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(124, 74);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(58, 21);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += BoardButton_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button4.Location = new Point(124, 98);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(58, 21);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += BoardButton_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button7.Location = new Point(124, 123);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(58, 21);
            button7.TabIndex = 4;
            button7.UseVisualStyleBackColor = true;
            button7.Click += BoardButton_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(61, 98);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(58, 21);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = true;
            button3.Click += BoardButton_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(187, 74);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(58, 21);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = true;
            button2.Click += BoardButton_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button8.Location = new Point(187, 123);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(58, 21);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += BoardButton_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button5.Location = new Point(187, 98);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(58, 21);
            button5.TabIndex = 8;
            button5.UseVisualStyleBackColor = true;
            button5.Click += BoardButton_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button6.Location = new Point(61, 123);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(58, 21);
            button6.TabIndex = 9;
            button6.UseVisualStyleBackColor = true;
            button6.Click += BoardButton_Click;
            // 
            // turnLabel
            // 
            turnLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            turnLabel.AutoSize = true;
            turnLabel.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            turnLabel.Location = new Point(92, 37);
            turnLabel.Margin = new Padding(2, 0, 2, 0);
            turnLabel.Name = "turnLabel";
            turnLabel.Size = new Size(140, 27);
            turnLabel.TabIndex = 10;
            turnLabel.Text = "Player X turn";
            turnLabel.Visible = false;
            // 
            // computerWins
            // 
            computerWins.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            computerWins.AutoSize = true;
            computerWins.Location = new Point(24, 202);
            computerWins.Name = "computerWins";
            computerWins.Size = new Size(103, 15);
            computerWins.TabIndex = 11;
            computerWins.Text = "Computer wins 10";
            computerWins.Visible = false;
            // 
            // playerWins
            // 
            playerWins.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            playerWins.AutoSize = true;
            playerWins.Location = new Point(207, 202);
            playerWins.Name = "playerWins";
            playerWins.Size = new Size(84, 15);
            playerWins.TabIndex = 12;
            playerWins.Text = "Player wins: 10";
            playerWins.Visible = false;
            // 
            // TikTacToe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 242);
            Controls.Add(playerWins);
            Controls.Add(computerWins);
            Controls.Add(turnLabel);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button8);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(button0);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "TikTacToe";
            Text = "Tic Tac Toe";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button button0;
        private Button button3;
        private Button button6;
        private Button button1;
        private Button button4;
        private Button button7;
        private Button button2;
        private Button button5;
        private Button button8;
        private Label turnLabel;
        private Label computerWins;
        private Label playerWins;
    }
}
