using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class AbstractAssignment
    {
        public static void Main()
        {

                                                                                   //calling methods in square
            Square ob1 = new Square();
            ob1.ReadValue();
            double area = ob1.FindArea();
            ob1.DisplayArea(area);
            Console.WriteLine("*****************************************************");                        
            Console.Write("\n");

                                                                                           //calling methods of circle


            Circle ob2 = new Circle();
            ob2.ReadCircle();
            double area2 = ob2.FindArea();
            ob2.DisplayArea(area2);
            Console.WriteLine("*****************************************************");
            Console.Write("\n");

                                                                                         //calling methods of traingle

            Traingle ob3 = new Traingle();
            ob3.ReadTraingle();
            double area3 = ob3.FindArea();
            ob3.DisplayArea(area3);



            Console.ReadKey();
        }
    }



    abstract class Shape
    {
        public const double PI = 3.14;



        public void DisplayArea(double x)
        {
            double area = x; ;

            Console.WriteLine("The area of the shape is :" + area);                        //To display
        }


        public abstract double FindArea();                                          //Declaring abstract Method

    }



    class Square : Shape
    {
        int side;

        public void ReadValue()
        {
            Console.WriteLine("enter the side lenght of square");                                  //This section is for the work on Square
            side = Convert.ToInt32(Console.ReadLine());

        }

        public override double FindArea()
        {
            int area;
            area = side * side;

            return area;
        }
    }



    class Circle : Shape
    {
        double radius;

        public void ReadCircle()
        {
            Console.WriteLine("enter the radius of circle");
            radius = Convert.ToInt32(Console.ReadLine());
                                                                                                       //This section is work on circle
        }

        public override double FindArea()
        {
            double area;
            area = (PI * radius * radius);
            return area;
        }

    }

    class Traingle:Shape
    {
        double breadth, height;
        public void ReadTraingle()
        {
            Console.WriteLine("enter the breadth of traingle");
            breadth = Convert.ToInt32(Console.ReadLine());                                          //The section is the work on traingle

            Console.WriteLine("enter the height of the traingle");
            height = Convert.ToInt32(Console.ReadLine());

        }

        public override double FindArea()
        {
            double area = (breadth * height) / 2;

            return area;
        }
    }
}
