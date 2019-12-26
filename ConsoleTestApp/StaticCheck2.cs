using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class StaticCheck2
    {

         public int i = 10;
         public static int j=10;


        public void Display()
        {
            Console.WriteLine("the value of i is" + i);
            Console.WriteLine("the value of j is" + j);

            i += 10;
            j += 10;

        }

        
        public static void Main()
        {
            StaticCheck2 ob1 = new StaticCheck2();
            StaticCheck2 ob2 = new StaticCheck2();
            StaticCheck2 ob3 = new StaticCheck2();
            StaticCheck2 ob4 = new StaticCheck2();
            
            ob1.Display();
            ob2.Display();
            ob3.Display();
            ob4.Display();
            Console.ReadKey();
        }
    }
}
