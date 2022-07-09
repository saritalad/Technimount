using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Binary_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"z:\\myfile.txt", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write("Hi....");
            bw.Close();
            fs.Close();
            fs = new FileStream(@"z:\\myfile.txt", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            Console.WriteLine(br.ReadString());
            br.Close();
            fs.Close();
            Console.ReadLine();
        }
    }
}
