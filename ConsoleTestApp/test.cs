using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class test
    {
       public static void Main(String[] args)
        {
            prime p1 = new prime();
            p1.read();
            p1.singleNum();
            p1.IntervalPrime();
            p1.Nprime();
            Console.ReadLine();
        }
    }
    class prime
    {
        int number, first, last;
        public Boolean CheckPrime(int x)
        {
            int y = x;
            Boolean c = true;
            for(int i=2;i<=x/2;i++)
            {
                if(x%i==0)
                {
                    c = false;
                    break;
                }
            }
            return c;
        }
        public void read()
        {
            Console.WriteLine("Enter the number");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first interval");
           first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter last interval");
            last = Convert.ToInt32(Console.ReadLine());

        }
        public void IntervalPrime()
        {
            for(int i=first;i<=last;i++)
            {
                if(CheckPrime(i))
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
        public void singleNum()
        {
            if(CheckPrime(number))
            {
                Console.WriteLine(number + " is prime");
            }
            else
            {
                Console.WriteLine(number + " is not prime");
            }
        }
        public void Nprime()
        {

            int count = 0;
            int i = 1;
            while(count<number)
            {
            
                    if(CheckPrime(i))
                    {
                        Console.WriteLine(i + "");
                        count++;
                    }
                i++;
                
            }
            
        }
    }
   
}
