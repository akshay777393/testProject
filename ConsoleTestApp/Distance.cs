using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Distance
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

        //THIS IS THE FIRST METHOD FOR FIND DISTANCE


        public void AddDistance(Distance objDistance1, Distance objDistance2)
        {

            feet = objDistance1.feet + objDistance2.feet;
            inches = objDistance1.inches + objDistance2.inches;

            if (inches >= 12)
            {
                feet++;
                inches %= 12;

            }
        }

       // THIS IS THE SECOND METHOD FOR FIND DISTANCE

        private Distance AddDistance(Distance distance2)
        {
            Distance d1 = new Distance();

            d1.feet = feet + distance2.feet;
            d1.inches = inches + distance2.inches;
            if (d1.inches >= 12)
            {
                d1.feet++;
                d1.inches %= 12;

            }


            return d1;

        }




        public static void Main()
        {
            Distance distance1 = new Distance();
            Distance distance2 = new Distance();
            Distance distance3 = new Distance();
            Distance distance4;

            Distance distance5;

            Console.WriteLine("Enter the value of Distance 1 :");
            Console.WriteLine("********************************:");
            distance1.ReadDistance();


            Console.WriteLine("Enter the value of Distance 2 :");
            Console.WriteLine("********************************:");
            distance2.ReadDistance();


            distance3.AddDistance(distance1, distance2);                           //CALLING FIRST METHOD

            Console.WriteLine("Distance 1 :");
            Console.WriteLine("**************:");
            distance1.DisplayDistance();
            Console.WriteLine("Distance 2 :");
            Console.WriteLine("**************:");
            distance2.DisplayDistance();
            Console.WriteLine("Distance 3 :");
            Console.WriteLine("**************:");
            distance3.DisplayDistance();                                            //DISPLAYING FIRST METHOD




            distance4 = distance1.AddDistance(distance2);                 //CALLING SECOND METHOD
            Console.WriteLine("Distance 4 :");
            Console.WriteLine("**************:");
            distance4.DisplayDistance();                                   //DISPLAYING SECOND METHOD





            distance5 = distance1 + distance2;

            Console.WriteLine("Distance 5 :");
            Console.WriteLine("**************:");
            distance5.DisplayDistance();



            Console.ReadKey();

        }

        public static Distance operator +(Distance d1, Distance d2)
        { 
        
            Distance d = new Distance();

            d.feet = d1.feet + d2.feet;
            d.inches = d1.inches + d2.inches;
            if (d.inches >= 12)
            {
                d.feet++;
                d.inches %= 12;

            }


            return d;


        }




    }
    }

