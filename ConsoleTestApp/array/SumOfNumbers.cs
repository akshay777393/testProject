using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.array
{
    class SumOfNumbers
    {
        int number;
        int[] values=new int[100];
        int resultSum=0;

        public void ReadData()
        {
            Console.WriteLine("Enter the  number of elements ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  elements ");
            for(int i=0;i<number;i++)
            {
                values[i] = Convert.ToInt32(Console.ReadLine());

            }
            

        }

        public void FindSum()
        {
            for(int i=0;i<number;i++)
            {
                resultSum += values[i];

            }

        }
        public void DisplayData()
        {
            Console.WriteLine("the sum of elements is:{0}", resultSum);
        }
      
        public static void Main()
        {

            SumOfNumbers ob1 = new SumOfNumbers();
            ob1.ReadData();
            ob1.FindSum();
            ob1.DisplayData();
            Console.ReadKey();

        }



    }
}
