using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Factorial
    {
        int n, Result = 1;
        public void ReadData()
        {
            Console.WriteLine("Enter the number to find factorial ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        public void FindFactorial()
        {
            for(int i=1;i<=n;i++)
            {
                Result = Result * i;
            }
        }
        public void DisplayData()
        {
            Console.WriteLine("the factorial of {0} is {1}", n, Result);
            Console.WriteLine("\n");
        }
        public static void Main()
        {
            Factorial ob1 = new Factorial();
            ob1.ReadData();
            ob1.FindFactorial();
            ob1.DisplayData();
            Console.ReadKey();
        }

    }
}
