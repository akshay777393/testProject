using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class BreakDeno
    {

        static void Main(string[] args)
        {
        p1:
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("i : " + i);
                for (int j = 1; j <= 10; j++)
                {


                    if (i == 3)
                    {

                        goto p1;
                        //  break;
                        // continue;
                    }
                    Console.Write(j + " ");

                }
                Console.WriteLine();
                Console.ReadKey();

            }

            Console.ReadKey();

        }

    }
}
