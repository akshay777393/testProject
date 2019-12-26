using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Fibonacci
    {
        int n1 = 0, n2 = 1, n3, number;
        public void ReadData()
        {

            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());

        }
        public void Fibonaccii()
        {
            Console.WriteLine(n1 + "\n " + n2 + "\n ");
            for (int i= 2;i< number;i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(+n3+ " ");
                n1 = n2;
                n2 = n3;
            }
        }
        public static void Main()
        {
            Fibonacci ob1 = new Fibonacci();
            ob1.ReadData();
            ob1.Fibonaccii();
            Console.ReadKey();
        }
    }
}
