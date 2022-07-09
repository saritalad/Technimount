using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technimount_Const_RaedOnly
{   class Product
    {


        public readonly string productname;
        public Product(string name)
        {

            productname = name;
        }

        public void Display()
        {

             const int PartId = 10;
            Console.WriteLine("PartId :"+PartId);
    
          }



    }

    class Program
    {
        static void Main(string[] args)
        {
            //Product p = new Product("Jack");
            //Console.WriteLine(p.productname);
            //p.Display();

            var student = new { Id = 1, FirstName = "James", LastName = "Bond" };
            Console.WriteLine(student.Id); //output: 1
            Console.WriteLine(student.FirstName); //output: James
            Console.WriteLine(student.LastName); //output: Bond
            var student1 = new
            {
                Id = 1,
                FirstName = "James",
                LastName = "Bond",
                Address = new { Id = 1, City = "London", Country = "UK" }
            };
            Console.WriteLine("city "+ student1.Address.City);
            Console.WriteLine(student.GetType().ToString());
        }
    }
}
