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
            int[,] arr = new int[3, 3]
            {
                {0 ,1,3},
                {4,5,2 } ,
                {6,7,8 } ,
            };

            Console.WriteLine(arr[1,2]);
            Console.WriteLine(arr.Rank);

            Console.WriteLine(arr.GetLength(1));

            Console.WriteLine("Accesing All the array elements using for loop...");

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(" "+arr[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
