using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covarience_Contravarience_Demo
{
    delegate Small contraDel(Big mc);
    class ContraVarienceProgram
    {
        static void Main(string[] args)
        {
            contraDel del = Method1;
            del += Method2;
            del += Method3;

          //  Small sm = del(new Big());
            del = Method4;

            Small sm = del(new Big());

        }

        static Big Method1(Big bg)
        {
            Console.WriteLine("Method1");
            return new Big();
        }
        static Small Method2(Big bg)
        {
            Console.WriteLine("Method2");
            return new Small();
        }

        static Small Method3(Small sml)
        {
            Console.WriteLine("Method3");

            return new Small();
        }

        static Big Method4(Small sml)
        {
            Console.WriteLine("Method3");

            return new Big();
        }



    }
}
