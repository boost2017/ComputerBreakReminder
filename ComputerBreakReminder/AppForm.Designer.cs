namespace ComputerBreakReminder
{
    partial class AppForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.shortBreakTime = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.longBreakTime = new System.Windows.Forms.TextBox();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            this.startupCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // shortBreakTime
            // 
            this.shortBreakTime.Location = new System.Drawing.Point(126, 25);
            this.shortBreakTime.Name = "shortBreakTime";
            this.shortBreakTime.ReadOnly = true;
            this.shortBreakTime.Size = new System.Drawing.Size(100, 22);
            this.shortBreakTime.TabIndex = 0;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(126, 99);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(89, 32);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Short Break:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Long Break:";
            // 
            // longBreakTime
            // 
            this.longBreakTime.Location = new System.Drawing.Point(126, 58);
            this.longBreakTime.Name = "longBreakTime";
            this.longBreakTime.ReadOnly = true;
            this.longBreakTime.Size = new System.Drawing.Size(100, 22);
            this.longBreakTime.TabIndex = 4;
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            // 
            // startupCheckBox
            // 
            this.startupCheckBox.AutoSize = true;
            this.startupCheckBox.Checked = true;
            this.startupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startupCheckBox.Location = new System.Drawing.Point(12, 151);
            this.startupCheckBox.Name = "startupCheckBox";
            this.startupCheckBox.Size = new System.Drawing.Size(125, 21);
            this.startupCheckBox.TabIndex = 5;
            this.startupCheckBox.Text = "Run at start-up";
            this.startupCheckBox.UseVisualStyleBackColor = true;
            this.startupCheckBox.CheckedChanged += new System.EventHandler(this.startupCheckBox_CheckedChanged);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 193);
            this.Controls.Add(this.startupCheckBox);
            this.Controls.Add(this.longBreakTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.shortBreakTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Break Reminder";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox shortBreakTime;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox longBreakTime;
        private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.CheckBox startupCheckBox;
    }
}

