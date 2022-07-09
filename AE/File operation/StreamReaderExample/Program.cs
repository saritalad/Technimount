using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace StreamReaderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("d:\\MyFile.txt"))
            {
                Console.WriteLine("File already exists");
            }

            StreamWriter sw = new StreamWriter("d:\\MyFile.txt");
            sw.WriteLine("Hello World");
            sw.Close();

            StreamReader sr = File.OpenText("d:\\MyFile.txt");
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
