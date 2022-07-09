using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technimount_Day3
{
    struct Point
    {
        int x { get; set; }
        int y { get; set; }
        public Point(int a,int b)
        {
          this.x = a;
            y = b;
        }

        public void Display()
        {
            Console.WriteLine("x ="+x+ " y ="+y);
        }
        public override string ToString()
        {
            return "x =" + x + " y =" + y;
        }
    }
    class Program
    {
        //static void Main()
        //{
        //    Point P = new Point(12, 24);
        //    P.Display();

       // }

    }

}
