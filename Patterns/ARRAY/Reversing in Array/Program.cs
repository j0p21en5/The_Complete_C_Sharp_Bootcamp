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
            Console.WriteLine("eneter the you want to store in array ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter Array elements : ");
            for (int i = 0; i < arr.Length; i++)
            {
                int b = int.Parse(Console.ReadLine());
                arr[i] = b;
            }
            //Console.WriteLine("Array Elements are : ");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            Array.Reverse(arr);
            Console.WriteLine("Reverse Array is : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //Console.WriteLine("Reverse Array is : ");

            //for (int i = arr.Length; i >= 1; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            Console.ReadLine();
        }
    }
}
