using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.array
{
    class CarParking
    {
        public int[] values = new int[5];

        public static void Main()
        {


            ParkCar ob1 = new ParkCar();
            int option;
            do
            {
                Console.WriteLine("**********************");
                Console.WriteLine("1. PARK CAR");
                Console.WriteLine("2. UNPARK CAR");
                Console.WriteLine("3.VIEW AVAILABLE SLOTS");
                Console.WriteLine("4.EXIT");
                Console.WriteLine("**********************");

                Console.WriteLine("Enter the option ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:


                        ob1.Parking();

                        break;
                    case 2:
                        ob1.TakeACar();
                        break;
                    case 3:
                        ob1.ShowStatus();
                        break;
                    default:
                        Console.WriteLine("plz Enter the correct option ");
                        break;
                }
            }
            while (true);
        }
    }

    class ParkCar : CarParking

    {


        public void Parking()
        {

            for (int i = 0; i < 5; i++)
            {

                if (values[i] == 0)
                {
                    values[i] = 1;
                    Console.WriteLine("Successfully parked at location {0}", i + 1);
                    break;
                }

            }
        }


        public void TakeACar()
        {
            int slot;
            Console.WriteLine("Enter the slot at which your car is parked:");//read parking slot number
            slot = Convert.ToInt32(Console.ReadLine());
            if (values[slot - 1] == 1)
            {
                Console.WriteLine("SUCCESS! YOU CAN TAKE YOUR CAR");
                values[slot - 1] = 0;
            }
            else
            {
                Console.WriteLine("Invalid !!");

            }
        }
        public void ShowStatus()
        {
            Console.WriteLine("\n");
         
            for (int i=0; i < 5; i++)
            {
                if (values[i] == 0)
                    Console.WriteLine("Slot no :" + (i + 1) + ":  Empty");
                else
                    Console.WriteLine("Slot no :" + (i + 1) + ":  Filled");
            }
            
        }
    }
}
