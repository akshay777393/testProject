using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class DistanceSub
    {

        int feet, inches;



        public void DisplayDistance()
        {
            Console.WriteLine("Feet : {0} Inches : {1}", feet, inches);

        }


        public void ReadDistance()
        {
            Console.WriteLine("Enter the value of Feet :");
            feet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of Inches :");
            inches = Convert.ToInt32(Console.ReadLine());

        }



        public void SubDistance(DistanceSub objDistance1, DistanceSub objDistance2)
        {
            if (objDistance1.feet > objDistance2.feet && objDistance1.inches < objDistance2.inches)
            {
               int ob;
                ob = objDistance1.inches + 12;
                

                objDistance1.inches = ob;
                

                objDistance1.feet = objDistance1.feet - 1;
                
                feet = objDistance1.feet - objDistance2.feet;
                inches = objDistance1.inches - objDistance2.inches;
            }
            else if (objDistance1.feet > objDistance2.feet && objDistance1.inches > objDistance2.inches)
            {
                feet = objDistance1.feet - objDistance2.feet;
                inches = objDistance1.inches - objDistance2.inches;

            }
            else if (objDistance1.feet < objDistance2.feet && objDistance1.inches > objDistance2.inches)
            {
                DistanceSub ob1 = objDistance1;
                objDistance1 = objDistance2;
                objDistance2 = ob1;

                int ob;
                ob = objDistance1.inches + 12;


                objDistance1.inches = ob;


                objDistance1.feet = objDistance1.feet - 1;

                feet = objDistance1.feet - objDistance2.feet;
                inches = objDistance1.inches - objDistance2.inches;

            }
            else
            {
                DistanceSub ob1 = objDistance1;
                objDistance1 = objDistance2;
                objDistance2 = ob1;

                feet = objDistance1.feet - objDistance2.feet;
                inches = objDistance1.inches - objDistance2.inches;

            }
        }

      








        public static void Main()
        {
            DistanceSub distance1 = new DistanceSub();
            DistanceSub distance2 = new DistanceSub();
            DistanceSub distance3 = new DistanceSub();

            Console.WriteLine("Enter the value of Distance 1 :");
            Console.WriteLine("********************************:");

            distance1.ReadDistance();


            Console.WriteLine("Enter the value of Distance 2 :");
            Console.WriteLine("********************************:");
            distance2.ReadDistance();



            //CALLING FIRST METHOD

            Console.WriteLine("Distance 1 :");
            Console.WriteLine("**************:");
            distance1.DisplayDistance();

            Console.WriteLine("Distance 2 :");
            Console.WriteLine("**************:");
            distance2.DisplayDistance();
            distance3.SubDistance(distance1, distance2);




            Console.WriteLine("Distance 3 :");
            Console.WriteLine("**************:");
            distance3.DisplayDistance();

            Console.ReadKey();
        }
    }
}
