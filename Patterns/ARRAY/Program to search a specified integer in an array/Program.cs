using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Program_to_search_a_specified_integer_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements you want to store in Array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the arry elements : ");

            for (int i = 0; i < arr.Length; i++)
            {
                int inp = int.Parse(Console.ReadLine());
                arr[i] = inp;
            }
            Console.WriteLine("Enter the element to found : ");
            int fon = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i] == fon)
                {
                    Console.WriteLine("Element found at index : "+i);
                }
                else
                {
                    count++;
                }
            }
            if(count>0)
            {
                Console.WriteLine("Element not found...");
            }
            

            Console.ReadLine();


        }
    }
}
