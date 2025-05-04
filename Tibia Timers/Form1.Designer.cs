namespace Tibia_Timers
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            notifyIcon1 = new NotifyIcon(components);
            label2 = new Label();
            RingTextBox = new TextBox();
            StartBtn = new Button();
            StopBtn = new Button();
            label3 = new Label();
            NeckTextBox = new TextBox();
            PotionCheckBox = new CheckBox();
            RingProgressBar = new ProgressBar();
            NeckProgressBar = new ProgressBar();
            PotionProgressBar = new ProgressBar();
            TitleLabel = new Label();
            PotionResetTimmerButton = new Button();
            RingResetTimmerButton = new Button();
            NeckResetTimmerButton = new Button();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 102);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Ring";
            // 
            // RingTextBox
            // 
            RingTextBox.Location = new Point(90, 98);
            RingTextBox.Name = "RingTextBox";
            RingTextBox.Size = new Size(45, 23);
            RingTextBox.TabIndex = 3;
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(28, 218);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(75, 23);
            StartBtn.TabIndex = 4;
            StartBtn.Text = "Start";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // StopBtn
            // 
            StopBtn.Location = new Point(227, 218);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(75, 23);
            StopBtn.TabIndex = 5;
            StopBtn.Text = "Stop";
            StopBtn.UseVisualStyleBackColor = true;
            StopBtn.Click += StopBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 138);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 6;
            label3.Text = "Neck";
            // 
            // NeckTextBox
            // 
            NeckTextBox.Location = new Point(90, 135);
            NeckTextBox.Name = "NeckTextBox";
            NeckTextBox.Size = new Size(45, 23);
            NeckTextBox.TabIndex = 7;
            // 
            // PotionCheckBox
            // 
            PotionCheckBox.AutoSize = true;
            PotionCheckBox.Location = new Point(74, 57);
            PotionCheckBox.Name = "PotionCheckBox";
            PotionCheckBox.Size = new Size(61, 19);
            PotionCheckBox.TabIndex = 8;
            PotionCheckBox.Text = "Potion";
            PotionCheckBox.UseVisualStyleBackColor = true;
            // 
            // RingProgressBar
            // 
            RingProgressBar.Location = new Point(162, 98);
            RingProgressBar.Name = "RingProgressBar";
            RingProgressBar.Size = new Size(100, 23);
            RingProgressBar.TabIndex = 9;
            // 
            // NeckProgressBar
            // 
            NeckProgressBar.Location = new Point(162, 135);
            NeckProgressBar.Name = "NeckProgressBar";
            NeckProgressBar.Size = new Size(100, 23);
            NeckProgressBar.TabIndex = 10;
            // 
            // PotionProgressBar
            // 
            PotionProgressBar.Location = new Point(162, 53);
            PotionProgressBar.Name = "PotionProgressBar";
            PotionProgressBar.Size = new Size(100, 23);
            PotionProgressBar.TabIndex = 11;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(90, 20);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(130, 15);
            TitleLabel.TabIndex = 12;
            TitleLabel.Text = "Tibia timer countdown:";
            // 
            // PotionResetTimmerButton
            // 
            PotionResetTimmerButton.Location = new Point(282, 53);
            PotionResetTimmerButton.Name = "PotionResetTimmerButton";
            PotionResetTimmerButton.Size = new Size(25, 23);
            PotionResetTimmerButton.TabIndex = 13;
            PotionResetTimmerButton.Text = "R";
            PotionResetTimmerButton.UseVisualStyleBackColor = true;
            PotionResetTimmerButton.Click += PotionResetTimmerButton_Click;
            // 
            // RingResetTimmerButton
            // 
            RingResetTimmerButton.Location = new Point(282, 98);
            RingResetTimmerButton.Name = "RingResetTimmerButton";
            RingResetTimmerButton.Size = new Size(25, 23);
            RingResetTimmerButton.TabIndex = 14;
            RingResetTimmerButton.Text = "R";
            RingResetTimmerButton.UseVisualStyleBackColor = true;
            RingResetTimmerButton.Click += RingResetTimmerButton_Click;
            // 
            // NeckResetTimmerButton
            // 
            NeckResetTimmerButton.Location = new Point(281, 135);
            NeckResetTimmerButton.Name = "NeckResetTimmerButton";
            NeckResetTimmerButton.Size = new Size(26, 23);
            NeckResetTimmerButton.TabIndex = 15;
            NeckResetTimmerButton.Text = "R";
            NeckResetTimmerButton.UseVisualStyleBackColor = true;
            NeckResetTimmerButton.Click += NeckResetTimmerButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 300);
            Controls.Add(NeckResetTimmerButton);
            Controls.Add(RingResetTimmerButton);
            Controls.Add(PotionResetTimmerButton);
            Controls.Add(TitleLabel);
            Controls.Add(PotionProgressBar);
            Controls.Add(NeckProgressBar);
            Controls.Add(RingProgressBar);
            Controls.Add(PotionCheckBox);
            Controls.Add(NeckTextBox);
            Controls.Add(label3);
            Controls.Add(StopBtn);
            Controls.Add(StartBtn);
            Controls.Add(RingTextBox);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Tibia Timers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private Label label2;
        private TextBox RingTextBox;
        private Button StartBtn;
        private Button StopBtn;
        private Label label3;
        private TextBox NeckTextBox;
        private CheckBox PotionCheckBox;
        private ProgressBar RingProgressBar;
        private ProgressBar NeckProgressBar;
        private ProgressBar PotionProgressBar;
        private Label TitleLabel;
        private Button PotionResetTimmerButton;
        private Button RingResetTimmerButton;
        private Button NeckResetTimmerButton;
    }
}
