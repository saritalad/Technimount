using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechniMount_Day4
{// unicast delegate 
    delegate string Joindel(string a, string b);

    class Program1
    {
        //static void Main(string[] args)
        //{
        //    Joindel obj = new Joindel(Fullname);
        //    Console.WriteLine(obj("sarita","lad"));
        //    Console.ReadLine();
        //}


        //public static string Fullname(string fname,string lname)
        //{
        //    return (fname + " " + lname).ToUpper();
        //}


    }
    // anonymous method
    //class Program2
    //{
    //    delegate int mydel(int a);

    //    static void Main(string[] args)
    //    {
    //        mydel obj = delegate (int x) { return x * x; };
    //        Console.WriteLine(" square of 5 = "+ obj(5));
    //    }
    //}


    // Lambda expression 
    //class Program3
    //{
    //    delegate int mydel(int a);
    //    delegate void HelloDel(string n);
    //    delegate void joindel(string f, string l);
    //    static void Main(string[] args)
    //    {
    //        mydel obj = x=> { return x * x; };
    //        Console.WriteLine(" square of 5 = " + obj(5));
    //        HelloDel obj1 = name => { Console.WriteLine("Hello " + name); };
    //        obj1("Sarita");
    //        joindel obj2 = delegate (string fname, string lname) { Console.WriteLine(fname + " " + lname); };
    //        obj2("sarita ", "Lad");

    //        joindel   obj3 = (f, l) => { Console.WriteLine(f + " " + l); };

    //        obj3("Ameet", "Lad");


    //    }

    //}
    // lambda statement 
    //class Program4
    //{
    //    delegate int countIt(int a);

    //    static void Main(string[] args)
    //    {
    //        countIt obj = (x) =>
    //          {
    //              int sum = 0;
    //              for (int i = 1; i <= x; i++)
    //              { sum += i; }
    //              return sum;
    //          };
    //        Console.WriteLine(obj(10));
    //    }
    //}
class Friend
    {
        public string name { get; set; }
        public int age{ get; set; }
    }
    class Program5
    {
        //static void Main(string[] args)
        //{
        //    List<Friend> friends = new List<Friend>();
        //    friends.Add(new Friend { name = "Amit", age = 23 });
        //    friends.Add(new Friend { name = "Sumit", age = 21 });
        //    friends.Add(new Friend { name = "Nill", age = 18 });
        //    friends.Add(new Friend { name = "Pradeep", age = 33 });
        //    var sortedlist = friends.OrderByDescending(f => f.age);
        //    foreach (var f in sortedlist)

        //        Console.WriteLine(f.name + " age " + f.age);
        //    var frirndlist = friends.OrderBy(f => f.name);

        //    foreach (var f in sortedlist)

        //        Console.WriteLine(f.name);
        //int[] numbers = { 2, 3, 4, 5 };
        //var squaredNumbers = numbers.Select(x => x * x);
        //Console.WriteLine(string.Join(" ", squaredNumbers));
        //}

    }
}
