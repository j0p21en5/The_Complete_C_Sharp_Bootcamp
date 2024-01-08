using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_smallest_element_int_the_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to store in the Array : ");
            int n = int.Parse(Console.ReadLine());
            
            int[] arr = new int[n];

            Console.WriteLine("Enter the array elements : ");

            for (int i = 0; i < arr.Length; i++)
            {
                int b = int. Parse(Console.ReadLine());
                arr[i] = b;
            }

            Console.WriteLine("Array Elements are : ");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Array.Sort(arr);
            Console.WriteLine("The second Smallest value in Array is : " + arr[1]);

            Console.ReadLine();
        }
    }
}
