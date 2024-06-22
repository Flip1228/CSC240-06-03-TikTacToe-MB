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
            highScoresToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            button0 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button1 = new Button();
            button6 = new Button();
            button8 = new Button();
            button7 = new Button();
            button2 = new Button();
            turnLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(303, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { highScoresToolStripMenuItem, optionsToolStripMenuItem, resetToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(47, 27);
            fileToolStripMenuItem.Text = "File";
            // 
            // highScoresToolStripMenuItem
            // 
            highScoresToolStripMenuItem.Name = "highScoresToolStripMenuItem";
            highScoresToolStripMenuItem.Size = new Size(180, 28);
            highScoresToolStripMenuItem.Text = "High Scores";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(180, 28);
            optionsToolStripMenuItem.Text = "Options";
            optionsToolStripMenuItem.Click += Menu_Options_Click;
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(180, 28);
            resetToolStripMenuItem.Text = "Reset";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 28);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += Menu_Exit_Click;
            // 
            // button0
            // 
            button0.Location = new Point(34, 113);
            button0.Name = "button0";
            button0.Size = new Size(75, 32);
            button0.TabIndex = 1;
            button0.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(115, 113);
            button3.Name = "button3";
            button3.Size = new Size(75, 32);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(115, 151);
            button4.Name = "button4";
            button4.Size = new Size(75, 32);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(115, 189);
            button5.Name = "button5";
            button5.Size = new Size(75, 32);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(34, 151);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(196, 113);
            button6.Name = "button6";
            button6.Size = new Size(75, 32);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(196, 188);
            button8.Name = "button8";
            button8.Size = new Size(75, 32);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(196, 151);
            button7.Name = "button7";
            button7.Size = new Size(75, 32);
            button7.TabIndex = 8;
            button7.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(34, 188);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = true;
            // 
            // turnLabel
            // 
            turnLabel.AutoSize = true;
            turnLabel.Font = new Font("Tempus Sans ITC", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            turnLabel.Location = new Point(70, 54);
            turnLabel.Name = "turnLabel";
            turnLabel.Size = new Size(140, 27);
            turnLabel.TabIndex = 10;
            turnLabel.Text = "Player X turn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 254);
            label1.Name = "label1";
            label1.Size = new Size(161, 23);
            label1.TabIndex = 11;
            label1.Text = "Computer wins: 234";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 254);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 12;
            label2.Text = "User wins: 213";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 316);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(turnLabel);
            Controls.Add(button2);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button0);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Tik Tac Toe";
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
        private ToolStripMenuItem highScoresToolStripMenuItem;
        private Button button0;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button1;
        private Button button6;
        private Button button8;
        private Button button7;
        private Button button2;
        private Label turnLabel;
        private Label label1;
        private Label label2;
    }
}
