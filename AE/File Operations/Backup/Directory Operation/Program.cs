 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Directory_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Directory D contains following folders:");
            //string[] dir = Directory.GetDirectories("D:\\");
            //foreach (string s in dir)
            //{
            //    Console.WriteLine(s);
            //}

            //string[] dirfiles = Directory.GetFiles("d:\\");
            //Console.WriteLine("Directory D contains following Files:");
            //foreach (string s in dirfiles)
            //{
            //    Console.WriteLine(s);
            //}
            string[] logdrive = Directory.GetLogicalDrives();
            Console.WriteLine("Total Number of Drives :" + logdrive.Length);
            foreach (string s in logdrive)
            {
                Console.WriteLine(s);
            }







        }
    }
}
