using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ComputerBreakReminder
{
    public partial class AppForm : Form
    {
        const int ShortBreakInterval = 20 * 60;
        const int LongBreakInterval = 55 * 60;
        private int secondsToShortBreak = ShortBreakInterval;
        private int secondsToLongBreak = LongBreakInterval;

        public AppForm()
        {
            this.SetStartup(true);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            InitializeComponent();
            this.countDownTimer.Tick += new EventHandler(countDownTimer_Tick);
            this.countDownTimer.Start();
            this.UpdateClocks();
        }

        void countDownTimer_Tick(object sender, EventArgs e)
        {
            this.secondsToShortBreak--;
            this.secondsToLongBreak--;

            if (this.secondsToShortBreak == 0)
            {
                if (this.secondsToLongBreak < ShortBreakInterval)
                {
                    this.secondsToShortBreak = ShortBreakInterval * 2;
                }
                else
                {
                    this.secondsToShortBreak = ShortBreakInterval;
                }

                this.TakeBreak(new ShortBreak(), "Short Break");
            }
            else if (this.secondsToLongBreak == 0)
            {
                this.secondsToShortBreak = ShortBreakInterval;
                this.secondsToLongBreak = LongBreakInterval;

                this.TakeBreak(new LongBreak(), "Long Break");
            }

            this.UpdateClocks();
        }

        private void UpdateClocks()
        {
            this.UpdateTimeLeft(this.shortBreakTime, this.secondsToShortBreak);
            this.UpdateTimeLeft(this.longBreakTime, this.secondsToLongBreak);
        }

        void TakeBreak(Form form, string message)
        {
            this.countDownTimer.Stop();
            this.longBreakTime.Text = this.shortBreakTime.Text = message;
            form.ShowDialog();
            this.countDownTimer.Start();
        }

        void UpdateTimeLeft(TextBox textBox, int seconds)
        {
            textBox.Text = string.Format(
                "{0:00}:{1:00}",
                seconds / 60,
                seconds % 60);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.countDownTimer.Stop();
            this.secondsToShortBreak = ShortBreakInterval;
            this.secondsToLongBreak = LongBreakInterval;
            this.countDownTimer.Start();
            this.UpdateClocks();
        }

        private void startupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.SetStartup(this.startupCheckBox.Checked);
        }

        private void SetStartup(bool runAtStartup)
        {
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (runAtStartup)
            {
                rkApp.SetValue("ComputerBreakReminder", Application.ExecutablePath.ToString());
            }
            else
            {
                rkApp.DeleteValue("ComputerBreakReminder", false);
            }
        }
    }
}
