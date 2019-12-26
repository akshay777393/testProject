using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.array
{
    class SortArray
    {


        int number;
        int key;
        int[] values = new int[100];


        public void ReadData()
        {
            Console.WriteLine("Enter the  number of elements ");
            number = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter the  elements ");
            for (int i = 0; i < number; i++)
            {
                values[i] = Convert.ToInt32(Console.ReadLine());

            }

        }


        public void SortValues()
        {
            int swapValue;
            for(int i=0;i<number;i++)
            {
                for(int j=i+1;j<number;j++)
                {
                    if(values[j]<values[i])
                    {
                        swapValue = values[i];
                        values[i] = values[j];
                        values[j] = swapValue;

                    }
                }
            }
        }

        public void BinarySearch()
        {
            Console.WriteLine("Enter the  Key to be searched ");
            key = Convert.ToInt32(Console.ReadLine());
            int min = 0;
            int max = number;
            int mid;

            while (min < max)
            {
                mid = (min + max) / 2;

                if (key < values[mid])
                {
                    max = mid - 1;

                }
                
               else if (key > values[mid])
                {

                    min = mid + 1;

                }
                
               else if(key == values[mid])
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("{0} Found  in location {1}", key, mid);
                    return;
                }

            }
            Console.WriteLine("NOT PRESENT IN THE ARRAY");
        }





        public void DisplayMatrix()
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(values[i] + "\t");

            }
        }
        public static void Main()
        {
            SortArray ob1 = new SortArray();
            ob1.ReadData();
            Console.WriteLine("****************THE GIVEN ARRAY IS..*****************");
            Console.WriteLine("\n");
            ob1.DisplayMatrix();
            Console.WriteLine("\n");
            ob1.SortValues();
            Console.WriteLine("****************THE SORTED ARRAY IS..*****************");
            Console.WriteLine("\n");
        
            ob1.DisplayMatrix();
            Console.WriteLine("\n");
            Console.WriteLine("****************BINARY SEARCH*****************");
            Console.WriteLine("\n");
            ob1.BinarySearch();
            Console.ReadKey();



        }
        }
}
