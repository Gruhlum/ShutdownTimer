using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownTimer
{
    public class AdvancedUpDown : NumericUpDown
    {
        public int Increments = 1;
        public override void UpButton()
        {
            this.Value = Math.Min(Maximum, (int)Math.Round((float)(this.Value + Increments) / (float)Increments) * Increments);
        }
        public override void DownButton()
        {
            //this.Value -= Math.Min(this.Value - Minimum, Increments);
            this.Value = Math.Max(Minimum, (int)Math.Round((float)(this.Value - Increments) / (float)Increments) * Increments);
        }
    }
}
