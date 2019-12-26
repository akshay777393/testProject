using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Ncr
    {

        int n, r;
        int ncr;

        public Ncr(int n, int r)                              //CONSTRUCTOR
        {
            this.n = n;
            this.r = r;

        }

        public void FindNcr()
        {
            ncr = FindFactorial(n) / ((FindFactorial(r)) * (FindFactorial(n - r)));
        }
        public static int FindFactorial(int f)
        {
            int fact = 1;

            for (int i = 1; i <= f; i++)
            {

                fact = fact * i;
            }
            return fact;

        }

        public void Display()
        {

            Console.WriteLine("n : {0}, r : {1}, ncr :{2}", n, r, ncr);
        }

        public static void Main()
        {

            Ncr ncr1 = new Ncr(10, 5);
            ncr1.FindNcr();
            ncr1.Display();
            Console.ReadKey();

        }

    }
}
