using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class SumProc
    {
        public static void Main(string[] args)
        {
            int value1, value2, value3;
            Console.WriteLine("Enter the first number");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            value2 = Convert.ToInt32(Console.ReadLine());
            value3 = value1 + value2;
            Console.WriteLine("value1 : " + value1);
            Console.WriteLine("value2 : " + value2);
            Console.WriteLine("value3 : " + value3);
            Console.ReadKey();

        }
    }
}
