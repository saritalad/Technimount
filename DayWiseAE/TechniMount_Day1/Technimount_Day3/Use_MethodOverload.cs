using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technimount_Day3
{
    class Use_MethodOverload
    {// Sum is a overloaded function
        // what is overloaded
        // it is having same name but different signature 
        // signature  comprise of 3 things
        //1 number of parameters or arguments 
        // 2 data type of parameters
        // 3 sequence of paramters having same data types 
        //static void Main()
        //{
        //    Sum(89, 56, 80.95f);
        //    Sum(89, 56, 45);
        //    Sum(89, 56);
        //    Sum(8100, 300);
        //}






        public static void Sum(int a, int b)
        {
            Console.WriteLine($" {a} + {b}= {(a+b)}");
        }
                public static void Sum(int a, int b,int c)
        {
            Console.WriteLine($" {a} + {b}+ {c}= {(a + b+c)}");
        }
        public static void Sum(int a, int b,float c)
        {
            Console.WriteLine($" {a} + {b}+ {c}= {(a + b+2*c)}");
        }
        public static void Sum(int a, float c ,int b )
        {
            Console.WriteLine($" {a} + {b}+ {c}= {(a + b + c)}");
        }

    }
}
