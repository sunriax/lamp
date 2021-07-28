using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaGae.App.Lamp.Forms.Extensions
{
    public static class NumericUpDownExtension
    {
        public static void TryValue(this NumericUpDown numeric, int value)
        {
            try
            {
                numeric.Value = value;
            }
            catch
            {
                numeric.Value = numeric.Minimum;
            }
        }
    }
}
