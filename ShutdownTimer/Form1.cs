using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            ToolStripMenuItemIncrement.Checked = Properties.Settings.Default.Increment;
        }

        public enum EXECUTION_STATE : uint
        {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
        }

        internal class NativeMethods
        {
            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Timer.Enabled = !Timer.Enabled;
            if (Timer.Enabled)
            {
                if (AUDHours.Value <= 0 && AUDMinutes.Value <= 0 && AUDSeconds.Value <= 2)
                {
                    AUDSeconds.Value = 3;
                }
                BtnStart.Text = "Stop";
            }
            else BtnStart.Text = "Start";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (AUDSeconds.Value <= 0)
            {
                if (AUDMinutes.Value <= 0)
                {
                    if (AUDHours.Value <= 0)
                    {
                        Timer.Stop();
                        Shutdown();
                    }
                    else
                    {
                        AUDHours.Value--;
                        AUDMinutes.Value = 59;
                        AUDSeconds.Value = 59;
                    }
                }
                else
                {
                    NativeMethods.SetThreadExecutionState(EXECUTION_STATE.ES_DISPLAY_REQUIRED);
                    AUDMinutes.Value--;
                    AUDSeconds.Value = 59;
                }
            }
            else AUDSeconds.Value--;
        }
        private void Shutdown()
        {
            var psi = new ProcessStartInfo("shutdown", "/s /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void ToolStripMenuItemIncrement_CheckedChanged(object sender, EventArgs e)
        {
            if (ToolStripMenuItemIncrement.Checked)
            {
                AUDHours.Increments = 15;
                AUDMinutes.Increments = 15;
                AUDSeconds.Increments = 15;
            }
            else
            {
                AUDHours.Increments = 1;
                AUDMinutes.Increments = 1;
                AUDSeconds.Increments = 1;
            }
            Properties.Settings.Default.Increment = ToolStripMenuItemIncrement.Checked;
            Properties.Settings.Default.Save();
        }
    }
}