using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_to_Sort_an_array_in_Descending_order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 56, 24, 85, 65, 3, 14, 2, 31, 4  };

            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0;j<arr.Length-1;j++)
                {
                    if (arr[j] >= arr[j+1])
                    {
                        temp = arr[j + 1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;  
                    }
                }
            }
            for (int i = arr.Length-1; i >=0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            //foreach (int i in arr)
            //{
            //    Console.WriteLine( i);
            //}
            Console.ReadLine();
        }
    }
}
