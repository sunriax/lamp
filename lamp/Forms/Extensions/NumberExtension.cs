using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaGae.App.Lamp.Forms.Extensions
{
    public static class NumberExtension
    {
        public static int Gray2Binary(this int num)
        {
            int temp = num ^ (num >> 8);
            temp ^= (temp >> 4);
            temp ^= (temp >> 2);
            temp ^= (temp >> 1);
            return temp;
        }
    }
}
