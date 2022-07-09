using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technimount_Day3
{                 
    //class Program
    //{
        //static void Main(string[] args)
        //{
        //      const int RollNo = 1284;// compile time 

        //  //  RollNo=RollNo +5;
        //    Emp emp = new Emp();
        //  //   emp.Id = 5;
        //    Emp emp1 = new Emp(5, "Bill");
        //   // emp1.Id = 10;
        //}
  //  }
    class Emp
    {
            
         public readonly int Id;
        public string Name { get; set; }
        public Emp()
        {            Id = 1;
            Name = "Synergy";
        }
          public Emp(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

    }

    //class Program
    //{
    //    static void Main()
    //    {
    //        MyMath.a = 300;
    //        MyMath.b = 500;
    //        Console.WriteLine(MyMath.Add());
    //        Employee e1 = new Employee();
    //        Console.WriteLine(e1);
    //    }

    //}

     static class MyMath
    {
     public   static int a;
     public   static int b;
        static MyMath ()
        {
            a = 100;
            b = 200;
            Console.WriteLine("static constructor");
        }
        public static int Add()
        {
            return a + b;
        }
        public static int Sub()
        {
            return a - b;
        }

    }

    








}
