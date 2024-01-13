using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_all_zeros_to_the_end_of_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 0, 6, 0, 4, 0 };
            int n = arr.Length-1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[arr.Length-n] = arr[i];
                    Console.WriteLine(arr[i]);
                    n--;
                }

            
            }
            Console.ReadLine();
        }
    }
}
