using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technimount_Day3
{
    // Outer class
    public class Outer_class
    {

        // Method of outer class
        public void method1()
        {
            Console.WriteLine("Outer class method");
        }

        // Inner class
        public class Inner_class
        {

            // Method of inner class
            public void method2()
            {
                Console.WriteLine("Inner class Method");
            }
        }

    }
        class UseofNestedClass
        {
            //static void Main()
            //{

            //    Outer_class obj1 = new Outer_class();
            //    obj1.method1();
            //    Outer_class.Inner_class obj2 = new Outer_class.Inner_class();

            //    // Accessing the method of inner class
            //    obj2.method2();



            //}



        }


    }

    
