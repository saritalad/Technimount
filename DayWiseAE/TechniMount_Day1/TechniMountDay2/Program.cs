
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechniMountDay2
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {  // Declare the Jagged Array of four elements:
    //        int[][] jagged_arr = new int[4][];

    //        // Initialize the elements
    //        jagged_arr[0] = new int[] { 1, 2, 3, 4 };
    //        jagged_arr[1] = new int[] { 11, 34, 67 };
    //        jagged_arr[2] = new int[] { 89, 23 };
    //        jagged_arr[3] = new int[] { 0, 45, 78, 53, 99 };

    //        // Display the array elements:
    //        for (int n = 0; n < jagged_arr.Length; n++)
    //        {

    //            // Print the row number
    //            System.Console.Write("Row({0}): ", n);

    //            for (int k = 0; k < jagged_arr[n].Length; k++)
    //            {

    //                // Print the elements in the row
    //                System.Console.Write("{0} ", jagged_arr[n][k]);
    //            }
    //            System.Console.WriteLine();
    //        }
    //        int[][] My = new int[3][];
    //        My[0] = new int[] { 1, 2, 3 };
    //        My[1] = new int[] { 5, 3 };
    //        My[2] = new int[] { 3, 5, 7, 8 };


    //        for (int i=0;i<My.Length; i++)
    //        {
    //            Console.WriteLine("Row {0}",i);
    //            for (int j = 0;j< My[i].Length; j++)
    //            {
    //                Console.WriteLine("{0}",My[i][j]);
    //            }


    //        }



    //    }
    //  }

    class Program
    {
        static void Main(string[] args)
        {
            var color = 'r';
            var x = 10;
            var y = 34.67;
            double a;
            int r = 7;
            Area(ref r, out a);
            Console.WriteLine($" Area  of radius {r}= {a}");


        }

        public static void Area(ref int r ,out double A)
        {
            A = Math.PI * r * r;

        }


    }





}