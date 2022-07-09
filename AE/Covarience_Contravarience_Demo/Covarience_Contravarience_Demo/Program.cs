using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covarience_Contravarience_Demo
{
    public class Small
    {

    }
    public class Big : Small
    {

    }
    public class Bigger : Big
    {

    }
    public delegate Small covarDel(Big mc);
    class Program
    {
        //static void Main(string[] args)
        //{
        //    covarDel del = Method1;

        //    Small sm1 = del(new Big());

        //    del = Method2;
        //    Small sm2 = del(new Big());

        //}








        public static Big Method1(Big bg)
        {
            Console.WriteLine("Method1");

            return new Big();
        }
        public static Small Method2(Big bg)
        {
            Console.WriteLine("Method2");

            return new Small();
        }

    }
}
