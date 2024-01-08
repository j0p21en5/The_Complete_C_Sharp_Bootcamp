using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Element_in_the_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number you want to store in the array : ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the Array elements Array : ");

            for (int i = 0; i < arr.Length; i++)
            {
                int b = int.Parse(Console.ReadLine());
                arr[i] = b;
            }
            Console.WriteLine("Array elements Are : ");

            for(int i = 0;i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Array.Sort(arr);
            Console.WriteLine("Sorted Array is : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            int len = arr.Length;

            Console.WriteLine("Largest Element in the Array is : " + arr[len-1]);

            Console.ReadLine();
        }
    }
}
