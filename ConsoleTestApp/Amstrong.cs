using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Amstrong
    {
        int value;
        public void ReadData()
        {
            Console.WriteLine("enter the number");
           value = Convert.ToInt32(Console.ReadLine());

        }

        public void Display(int x)
        {
            int value2 = x;
            if (x == value)
            {
                Console.WriteLine("the given value is Amstrong");
            }
            else
            {
                Console.WriteLine("not amstrong");
            }

        }

        public int Check(int x)
        {
            int a = x, b = x;
            int rem, sum = 0;
            int i = 0;
            do
            {

                a = a / 10;
                i++;

            } while (a > 0);


            do
            {
                rem = b % 10;
                sum = sum + (int)Math.Pow(rem, i);

                b = b / 10;



            } while (b > 0);

            return sum;
        }

        public static void Main()
        {
            Amstrong ob1 = new Amstrong();
            ob1.ReadData();
           int sum= ob1.Check(ob1.value);
            ob1.Display(sum);

            Console.ReadKey();



        }
    }
}
