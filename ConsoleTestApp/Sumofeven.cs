using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Sumofeven
    {
        int i, sum = 0, n;
        public void ReadData()
        {
            Console.WriteLine("Enter the number upto find sum");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public void FindSum()
        {
            for (i = 0; i <= n; i += 2)
            {
                sum = sum + i;
            }
        }
        public void Display()
        {

            Console.WriteLine("The sum upto number is :" + sum);

        }
        public static void Main(string[] args)
        {
            Sumofeven objSum = new Sumofeven();
            objSum.ReadData();
            objSum.FindSum();
            objSum.Display();
            Console.ReadKey();
        }
    }
}
