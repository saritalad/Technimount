using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechniMount_Day4
{
    class Generics
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x => x * x;
            Func<string, string, string> FullName = (fname, lname) => fname + " " + lname;
            Console.WriteLine(square(5));
        }
    }
}
