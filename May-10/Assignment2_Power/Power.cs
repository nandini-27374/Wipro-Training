using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Math_Operation
    {
        public int Power(int base_val,int expo_val)
        {
            return (int)Math.Pow(base_val, expo_val);
        }

        public double Power(double base_val, double expo_val)
        {
            return (double)Math.Pow(base_val, expo_val);
        }
    }
}