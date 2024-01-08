using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_Element_in_the_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to store in Array : ");
            int n =int.Parse(Console.ReadLine());

            

            int[] arr = new int[n];
            Console.WriteLine("Enter the array elemnts : ");
            for (int i = 0; i < arr.Length; i++)
            {
                int inp = int.Parse(Console.ReadLine());
                arr[i] = inp;
            }
            Console.WriteLine("Array Elements Array : ");
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

            Array.Sort(arr);
            Console.WriteLine("Sorted Array is : ");
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Smallest Element in the array is : "+arr[0]);
            Console.ReadLine();
        }
    }
}
