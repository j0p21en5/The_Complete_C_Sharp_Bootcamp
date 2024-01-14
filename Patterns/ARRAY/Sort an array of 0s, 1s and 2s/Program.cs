using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_an_array_of_0s__1s_and_2s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 0, 1, 0, 2, 0, 0, 2, 1 };

            int count1 = 0, count2 = 0; 

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    Console.WriteLine(arr[i]);
                }
                continue;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    Console.WriteLine(arr[i]);
                }
                continue;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 2)
                {
                    Console.WriteLine(arr[i]);
                }
                continue;
            }

            Console.ReadLine();





        }
    }
}
