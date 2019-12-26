using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.Properties
{
    

    class Program
    {

        public static void Main(string[] args)
        {
            SortString S1 = new SortString();
            S1.Input();
            S1.SortAscending();
            S1.SortDescending();
            S1.Display();
            Console.ReadKey();
        }



    }
    //class defenition
    class SortString
    {
        //declaring variables
        int size;
        string String;

        char[] ascendingString;
        char[] descendingString;
        //Read the String
        public void Input()
        {


            Console.WriteLine("Enter the String : ");

            String = Console.ReadLine();
            size = String.Length;
            ascendingString = new char[size];
            descendingString = new char[size];
            for (int i = 0; i < size; i++)
            {
                ascendingString[i] = String[i];
                descendingString[i] = String[i];
            }
        }
        //sorting in ascending order
        public void SortAscending()
        {
            char temp;
            int i, j;
            for (i = 0; i < size; i++)
            {
                for (j = 0; j < i; j++)
                {
                    if (ascendingString[i] < ascendingString[j])
                    {
                        //swap the values
                        temp = ascendingString[i];
                        ascendingString[i] = ascendingString[j];
                        ascendingString[j] = temp;
                    }
                }
            }
        }
        //sorting in descending order
        public void SortDescending()
        {
            char temp;
            int i, j;
            for (i = 0; i < size; i++)
            {
                for (j = 0; j < i; j++)
                {
                    if (descendingString[i] > descendingString[j])
                    {
                        //swap the values
                        temp = descendingString[i];
                        descendingString[i] = descendingString[j];
                        descendingString[j] = temp;
                    }
                }
            }
        }
        //display input and output
        public void Display()
        {

            Console.Write("\n\nString before sorting  :  ");

            Console.Write(String);
            Console.Write("\n\nIn ascending order    :  ");

            Console.Write(ascendingString);
            Console.Write("\n\nIn descending order   :  ");

            Console.Write(descendingString);
        }
    }
}
