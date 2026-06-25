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
            int next = (int)Math.Ceiling((Value + 1) / Increments) * Increments;
            Value = Math.Min(Maximum, next);
        }

        public override void DownButton()
        {
            int next = (int)Math.Floor((Value - 1) / Increments) * Increments;
            Value = Math.Max(Minimum, next);
        }

    }
}
