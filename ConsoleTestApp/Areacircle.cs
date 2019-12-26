using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Areacircle
    {
        int r;
        double A, B;
        public void ReadData()
        {
            Console.WriteLine("Enter the radius");
            r = Convert.ToInt32(Console.ReadLine());
        }
        public void AreaofCircle()
        {
            A = (3.14) * r * r;
        }
        public void Circumference()
        {
            B = 2 * (3.14) * r;
        }
        public void Display()
        {

            Console.WriteLine("area of circle :" + A);
            Console.WriteLine("circumference of circle :" + B);
        }
        public static void Main(string[] args)
        {
            Areacircle objCircle = new Areacircle();
            objCircle.ReadData();
            objCircle.AreaofCircle();
            objCircle.Circumference();
            objCircle.Display();
            Console.ReadKey();
        }

    }
}
