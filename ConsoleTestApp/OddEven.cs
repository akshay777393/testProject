using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class OddEven
    {
        int value;
        string i;
        public void ReadData()
        {
            Console.WriteLine("Enter the number");
            value = Convert.ToInt32(Console.ReadLine());
        }

        public void FindOddEven()
        {
            if(value%2==0)
            {
                i = "the number is even";
            }else
            {
                i = "the number is odd";
            }
        }
        public void Display()
        {

            Console.WriteLine(i);
        }
        public static void Main(string[] args)
        {
            OddEven objSum = new OddEven();
            objSum.ReadData();
            objSum.FindOddEven();
            objSum.Display();
            Console.ReadKey();
        }
    }
}
