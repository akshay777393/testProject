using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Calculate
    {
        public static int Sum(int val1,int val2)
        {
            int val3;
            val3 = val1 + val2;
            return val3;
        }
        public int Diff(int val1,int val2)
        {
            int val3;
            val3 = val1 - val2;
            return val3;
        }
    }
}
