using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class StaticCheck
    {
        public  int i;
        public static int j;


        public void  Display()
        {
            Console.WriteLine("the value of i is" + i);
            Console.WriteLine("the value of j is" + j);

            i += 10;
            j += 10;

        }

        public void  ReadData()
        {
            Console.WriteLine("enter the value of i");
            i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the value of j");
            j = Convert.ToInt32(Console.ReadLine());
        }

        public static void Main()
        {
            StaticCheck ob1 = new StaticCheck();
            StaticCheck ob2 = new StaticCheck();
            StaticCheck ob3 = new StaticCheck();
            StaticCheck ob4 = new StaticCheck();
            ob1.ReadData();
            ob1.Display();
            ob2.Display();
            ob3.Display();
            ob4.Display();
            Console.ReadKey();
        }




    }
}
