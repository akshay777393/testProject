using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class ReverseNumber
    {
        int n, result=0;
        public void ReadData()
        {
            Console.WriteLine("Enter the number for reversing ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public void Reverse()
        {
            int rem, p=n;
            while (p != 0)
            {
                rem = p % 10;
                result = result * 10 + rem;
                p /= 10;
            }
        }
        public void DisplayData()
        {
            Console.WriteLine("the reverse of {0} is {1}", n, result);
        }
        public static void Main(string[] args)
        {
            ReverseNumber ob1 = new ReverseNumber();
            ob1.ReadData();
            ob1.Reverse();
            ob1.DisplayData();
            Console.ReadKey();
        }
    }
}
