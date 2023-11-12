using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ShutdownTimer
{
    public partial class Form1 : Form
    {
        Thread FadeThread;

        public enum EXECUTION_STATE : uint
        {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001,
        }

        internal class NativeMethods
        {
            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);
        }

        public delegate void DoWorkCallback(decimal result);

        public Form1()
        {
            InitializeComponent();
            ToolStripMenuItemIncrement.Checked = Properties.Settings.Default.Increment;
            ToolStripMenuItemFade.Checked = Properties.Settings.Default.Fade;
            LoadSettings();
            FormClosed += Form1_FormClosed;          
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopThread();
        }

        private void CallToChildThread()
        {
            Fade f = new Fade(GetTotalTimeInSeconds());
            f.ShowDialog();
        }
        private void StartThread()
        {
            if (Properties.Settings.Default.Fade)
            {
                ThreadStart childref = new ThreadStart(CallToChildThread);
                FadeThread = new Thread(childref);
                FadeThread.Start();
            }
        }       
        private void StopThread()
        {
            if (FadeThread != null)
            {
                FadeThread.Abort();
            }           
        }
        private decimal GetTotalTimeInSeconds()
        {
            return AUDSeconds.Value + AUDMinutes.Value * 60 + AUDHours.Value * 60 * 60;
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            Timer.Enabled = !Timer.Enabled;
            if (Timer.Enabled)
            {
                NativeMethods.SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_SYSTEM_REQUIRED);
                if (AUDHours.Value <= 0 && AUDMinutes.Value <= 0 && AUDSeconds.Value <= 2)
                {
                    AUDSeconds.Value = 3;
                }
                StartThread();
                BtnStart.Text = "Stop";
            }
            else
            {
                NativeMethods.SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
                StopThread();
                BtnStart.Text = "Start";
            }
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
        private void LoadSettings()
        {
            if (ToolStripMenuItemIncrement.Checked)
            {
                AUDHours.Increments = 1;
                AUDMinutes.Increments = 15;
                AUDSeconds.Increments = 15;
            }
            else
            {
                AUDHours.Increments = 1;
                AUDMinutes.Increments = 1;
                AUDSeconds.Increments = 1;
            }
        }
        private void ToolStripMenuItemIncrement_CheckedChanged(object sender, EventArgs e)
        {
            LoadSettings();
            Properties.Settings.Default.Increment = ToolStripMenuItemIncrement.Checked;
            Properties.Settings.Default.Save();
        }

        private void ToolStripMenuItemFade_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Fade = ToolStripMenuItemFade.Checked;
            Properties.Settings.Default.Save();
        }
    }
}