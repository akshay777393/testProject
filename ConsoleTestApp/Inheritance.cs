using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Inheritance
    {





        public static void Main()
        {
            //A ob1 = new A();
           // ob1.Display();
            B ob2 = new B(35,45);
            ob2.Display();
            Console.ReadKey();



        }
        
        class A
        {
            public int val1;
            public A()
            {
                val1 = 10;
            }
            public A(int v1)
            {
                val1 = v1;
            }

            public virtual void Display()
            {
                Console.WriteLine("Im in base class A val1:" + val1);
            }
        }
        class B:A
        {
            int val2;

            public B()
            {
                val2 = 100;
            }

            public B(int v1,int v2) :base(v1)
            {
                val2 = v2 ;
            }
            public override void Display()
            {
                Console.WriteLine("im in base class A val1:" + val1);
                Console.WriteLine("im in derived class B val2:" + val2);
            }
        }
    }
}
