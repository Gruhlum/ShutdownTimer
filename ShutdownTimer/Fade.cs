using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ShutdownTimer
{
    public partial class Fade : Form
    {
        private decimal maximumTime = 300;
        private decimal startTime;
        private decimal secondsLeft;
        public Fade(decimal totalSeconds)
        {
            if (totalSeconds <= 4)
            {
                return;
            }
            startTime = totalSeconds;
            secondsLeft = totalSeconds;
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            secondsLeft--;
            //Debug.WriteLine(Name + " - " + Opacity);
            if (secondsLeft > 300)
            {
                return;
            }
            float upperLimit = (float)Math.Min(maximumTime, startTime);
            Opacity = Math.Min(0.98f, (upperLimit - (float)secondsLeft) / upperLimit);          
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_LAYERED = 0x80000;
                const int WS_EX_TRANSPARENT = 0x20;
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_LAYERED;
                cp.ExStyle |= WS_EX_TRANSPARENT;
                cp.ExStyle |= 0x80;
                return cp;
            }
        }
    }
}
