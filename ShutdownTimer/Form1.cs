using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Timer.Enabled = !Timer.Enabled;
            if (Timer.Enabled)
            {
                if (NumHours.Value <= 0 && NumMinutes.Value <= 0 && NumSeconds.Value <= 2)
                {
                    NumSeconds.Value = 3;
                }
                BtnStart.Text = "Stop";
            }
            else BtnStart.Text = "Start";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (NumSeconds.Value <= 0)
            {                             
                if (NumMinutes.Value <= 0)
                {
                    if (NumHours.Value <= 0)
                    {
                        Timer.Stop();
                        Shutdown();
                    }
                    else
                    {
                        NumHours.Value--;
                        NumMinutes.Value = 59;
                        NumSeconds.Value = 59;
                    }
                }
                else
                {
                    NumMinutes.Value--;
                    NumSeconds.Value = 59;
                }               
            }
            else NumSeconds.Value--;
        }
        private void Shutdown()
        {
            var psi = new ProcessStartInfo("shutdown", "/s /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }
    }
}
