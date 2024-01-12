using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_An_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 4, 6, 7, 2, 3, 1 };
            //int[] arr2 = new int[arr.Length];
            int p = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        p = arr[j+1];
                        arr[j+1] = arr[j];
                        arr[j] = p;
                    }
                    
                    
                    
                }
            }
            Console.WriteLine("Sorted Array");
            for (int i = 0;i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }






            Console.ReadLine();
        }
    }
}
