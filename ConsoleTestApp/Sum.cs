using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Sum
    {
        int value1, value2, value3;

        public void ReadData()
        {
            Console.WriteLine("Enter the first one");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            value2 = Convert.ToInt32(Console.ReadLine());
        }
        public void FindSum()
        {
            value3 = value1 + value2;
        }
        public void DisplayData()
        {
            Console.WriteLine("value1 : " + value1);
            Console.WriteLine("value2 : " + value2);
            Console.WriteLine("value3 : " + value3);
        }
        public static void Main(string[] args)
        {
            Sum objSum = new Sum();
            objSum.ReadData();
            objSum.FindSum();
            objSum.DisplayData();
            Console.ReadKey();

        }
    }
}
