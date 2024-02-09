using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array_strt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rectangular Array ...
            int[,] arr = new int[3, 3];
            //{
            //    {0 ,1,3},
            //    {4,5,2 } ,
            //    {6,7,8 } ,
            //};
            Console.WriteLine("Enter Array elements  : ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine("Enter element of row index : "+i);
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int b = int.Parse(Console.ReadLine());
                    arr[i, j] = b;
                }
            }

            //Console.WriteLine(arr[1,2]);
            //Console.WriteLine(arr.Rank);

            //Console.WriteLine(arr.GetLength(1));

            Console.WriteLine("Accesing All the array elements using for loop...");

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(" " + arr[i, j]);
                }
                Console.WriteLine();
            }


            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);

            //


            //JAGGED ARRAY

            //int[][] arr = new int[3][];

            //arr[0] = new[] { 1, 2, 3 };
            //arr[1] = new[] { 5, 6, 7, 4, 6 };
            //arr[2] = new[] { 6, 8, 6, 4, 7, 8 };

            //Console.WriteLine(arr[0][2]);

            //Console.WriteLine("accesing jaggd array using for loop.......");
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write(" "+arr[i][j]);
            //    }
            //    Console.WriteLine();
            //}


            Console.ReadLine();

        }
    }
}
