using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Sream_Reader_Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("d:\\ur.txt"))
            {
                Console.WriteLine("File already exists");
            }

            StreamWriter sw = new StreamWriter("d:\\ur.txt");
            sw.WriteLine("Hello World");
            sw.Close();

            if (File.Exists("z:\\my.txt"))
            {
                Console.WriteLine("File already exists");
            }

            StreamReader sr = File.OpenText("z:\\my.txt");
            string txt;
            while ((txt = sr.ReadLine()) != null)
            {
                Console.WriteLine(txt);
            }

            Console.WriteLine("End of stream");
            sr.Close();
            Console.ReadLine();  
        }
    }
}
