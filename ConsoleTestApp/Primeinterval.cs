using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Primeinterval
    {
        int n, firstend, lastend;
        int ctr;
        public void ReadData()
        {
            Console.WriteLine("enter the first interval");
            firstend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the last interval");
            lastend = Convert.ToInt32(Console.ReadLine());
        }
        public void FindNumber()
        {

            for (n = firstend; n <= lastend; n++)
            {
                ctr = 0;
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }
                if (ctr == 0 && n != 1)
                {
                    Console.WriteLine("{0}", n);
                }
            }
        }
        public static void Main()
        {
            Primeinterval ob1 = new Primeinterval();
            ob1.ReadData();
            ob1.FindNumber();
   
            Console.ReadKey();
        }

    }
}
