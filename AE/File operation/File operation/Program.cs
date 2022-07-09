using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace File_operation
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Console.WriteLine("Directory");
        //    string[] dir = Directory.GetDirectories("C:\\Inetpub\\wwwroot\\");
        //    foreach (string s in dir)
        //    {
        //        Console.WriteLine(s);
        //    }

            string[] dirfiles = Directory.GetFiles("C:\\Windows\\Media\\");
            foreach (string s in dirfiles)
            {
                Console.WriteLine(s);
            }

            string[] logdrive = Directory.GetLogicalDrives();
            Console.WriteLine("Total Number of Drives = " + logdrive.Length);
            foreach (string s in logdrive)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Directory Info class");
            DirectoryInfo d = new DirectoryInfo("C:\\windows\\Media");
            Console.WriteLine("Name: " + d.Name);
            Console.WriteLine("Parent: " + d.Parent);
            Console.WriteLine("Root: " + d.Root);
            Console.WriteLine("Creation Time: " + d.CreationTime);
            Console.WriteLine("Full Name: " + d.FullName);
           

            Console.ReadLine();   
        }
    }
}
