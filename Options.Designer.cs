namespace TicTacToe
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            easyRadio = new RadioButton();
            normalRadio = new RadioButton();
            hardRadio = new RadioButton();
            selectButton = new Button();
            difficultyGroup = new GroupBox();
            markerGroup = new GroupBox();
            xMarkerRadio = new RadioButton();
            oMarkerRadio = new RadioButton();
            difficultyGroup.SuspendLayout();
            markerGroup.SuspendLayout();
            SuspendLayout();
            // 
            // easyRadio
            // 
            easyRadio.AutoSize = true;
            easyRadio.Location = new Point(31, 40);
            easyRadio.Name = "easyRadio";
            easyRadio.Size = new Size(61, 27);
            easyRadio.TabIndex = 0;
            easyRadio.Text = "Easy";
            easyRadio.UseVisualStyleBackColor = true;
            easyRadio.CheckedChanged += Difficulty_CheckedChanged;
            // 
            // normalRadio
            // 
            normalRadio.AutoSize = true;
            normalRadio.Location = new Point(31, 73);
            normalRadio.Name = "normalRadio";
            normalRadio.Size = new Size(85, 27);
            normalRadio.TabIndex = 0;
            normalRadio.Text = "Normal";
            normalRadio.UseVisualStyleBackColor = true;
            normalRadio.CheckedChanged += Difficulty_CheckedChanged;
            // 
            // hardRadio
            // 
            hardRadio.AutoSize = true;
            hardRadio.Location = new Point(31, 106);
            hardRadio.Name = "hardRadio";
            hardRadio.Size = new Size(65, 27);
            hardRadio.TabIndex = 0;
            hardRadio.Text = "Hard";
            hardRadio.UseVisualStyleBackColor = true;
            hardRadio.CheckedChanged += Difficulty_CheckedChanged;
            // 
            // selectButton
            // 
            selectButton.BackColor = Color.Silver;
            selectButton.FlatStyle = FlatStyle.Popup;
            selectButton.Location = new Point(12, 259);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(336, 40);
            selectButton.TabIndex = 3;
            selectButton.Text = "Select";
            selectButton.UseVisualStyleBackColor = false;
            selectButton.Click += selectButton_Click;
            // 
            // difficultyGroup
            // 
            difficultyGroup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            difficultyGroup.Controls.Add(easyRadio);
            difficultyGroup.Controls.Add(normalRadio);
            difficultyGroup.Controls.Add(hardRadio);
            difficultyGroup.FlatStyle = FlatStyle.Popup;
            difficultyGroup.Location = new Point(176, 70);
            difficultyGroup.Name = "difficultyGroup";
            difficultyGroup.Size = new Size(172, 164);
            difficultyGroup.TabIndex = 51;
            difficultyGroup.TabStop = false;
            difficultyGroup.Text = "Pick your difficulty";
            // 
            // markerGroup
            // 
            markerGroup.BackgroundImageLayout = ImageLayout.None;
            markerGroup.Controls.Add(xMarkerRadio);
            markerGroup.Controls.Add(oMarkerRadio);
            markerGroup.FlatStyle = FlatStyle.Popup;
            markerGroup.Location = new Point(12, 104);
            markerGroup.Name = "markerGroup";
            markerGroup.Size = new Size(154, 130);
            markerGroup.TabIndex = 52;
            markerGroup.TabStop = false;
            markerGroup.Text = "Pick your marker";
            // 
            // xMarkerRadio
            // 
            xMarkerRadio.AutoSize = true;
            xMarkerRadio.Location = new Point(44, 78);
            xMarkerRadio.Name = "xMarkerRadio";
            xMarkerRadio.Size = new Size(49, 27);
            xMarkerRadio.TabIndex = 0;
            xMarkerRadio.TabStop = true;
            xMarkerRadio.Text = "X's";
            xMarkerRadio.UseVisualStyleBackColor = true;
            xMarkerRadio.CheckedChanged += Marker_CheckedChanged;
            // 
            // oMarkerRadio
            // 
            oMarkerRadio.AutoSize = true;
            oMarkerRadio.Location = new Point(44, 45);
            oMarkerRadio.Name = "oMarkerRadio";
            oMarkerRadio.Size = new Size(52, 27);
            oMarkerRadio.TabIndex = 0;
            oMarkerRadio.TabStop = true;
            oMarkerRadio.Text = "O's";
            oMarkerRadio.UseVisualStyleBackColor = true;
            oMarkerRadio.CheckedChanged += Marker_CheckedChanged;
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 320);
            Controls.Add(markerGroup);
            Controls.Add(difficultyGroup);
            Controls.Add(selectButton);
            Name = "Options";
            Text = "Options";
            difficultyGroup.ResumeLayout(false);
            difficultyGroup.PerformLayout();
            markerGroup.ResumeLayout(false);
            markerGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton easyRadio;
        private RadioButton normalRadio;
        private RadioButton hardRadio;
        private Button selectButton;
        private GroupBox difficultyGroup;
        private GroupBox markerGroup;
        private RadioButton xMarkerRadio;
        private RadioButton oMarkerRadio;
    }
}