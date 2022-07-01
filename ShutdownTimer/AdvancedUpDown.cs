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
        public int Increments = 15;
        public override void UpButton()
        {
            this.Value += Math.Min(Maximum - this.Value, Increments);
        }
        public override void DownButton()
        {
            this.Value -= Math.Min(this.Value - Minimum, Increments);
        }
    }
}
