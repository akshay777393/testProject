using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class DigitSum
    {
        int number;
        


        int digitSum;

        public void ReadData()
        {
            Console.WriteLine("Enter the value of number ");
            number = Convert.ToInt32(Console.ReadLine());
            
        }
        public void DisplayData()
        {
            Console.WriteLine("the single digit sum of the number is {0} ", digitSum);

        }
        public int FindDigitSum()
        {
            int n = number;
            int lastDigit;
            do
            {
                lastDigit = n % 10;
                digitSum += lastDigit;
                n = n / 10;
            } while (n > 0);

            return digitSum;
        }
        public void FindDigitSum(int x)
        {
            int n= x;
            int lastDigit;
            do
            {
                lastDigit = n % 10;
                digitSum += lastDigit;
                n = n / 10;
            } while (n > 0);

           
        }
        public static void Main()
        {
   
            DigitSum ob1 = new DigitSum();
            DigitSum ob2 = new DigitSum();
            ob1.ReadData();
            int a=ob1.FindDigitSum();
            
            ob2.FindDigitSum(a);
            ob2.DisplayData();

            Console.ReadKey();
        }
    }
}
