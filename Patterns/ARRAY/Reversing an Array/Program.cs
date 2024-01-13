using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversing_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 2, 6, 7, 3, 1, 2, 4 };

            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            
            
            
            
            
            
            
            
            
            
            
            
            //int temp = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length-1; j++)
            //    {
            //        if (arr[j] >= arr[j +1] )
            //        {
            //            temp = arr[j+1];
            //            arr[j+1] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }

            //}
            

            //Console.WriteLine("Sorted Array is : ");

            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            Console.ReadLine();
        }
    }
}





