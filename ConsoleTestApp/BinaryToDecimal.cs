using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class BinaryToDecimal
    {
        public void DisplayData(int y)
        {
            Console.WriteLine("the decimal number is:{0}",y );
        }

        public int Convertion(int x)
        {
            int number = x;
            int sum = 0;
            int i = 0;
            int lastDigit;
            do
            {               
                lastDigit = number % 10;
                sum+=lastDigit*(int)Math.Pow(2, i);

                number = number / 10;

                i++;
            } while (number > 0);
         
            return sum;
        }

        public static void Main()
        {
            BinaryToDecimal ob1 = new BinaryToDecimal();
            int Decimal=ob1.Convertion(110);
            ob1.DisplayData(Decimal);
            Console.ReadKey();
        }
    }
}
