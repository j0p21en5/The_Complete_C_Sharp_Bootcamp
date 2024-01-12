using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_to_delete_a_specified_integer_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the element you want to store in array : ");
            int n  = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the Element...");
            for (int i = 0; i < arr.Length; i++)
            {
                int b = int.Parse(Console.ReadLine());
                arr[i] = b;
            }
            Console.WriteLine("Enter the element to remove : ");
            int rem= int.Parse(Console.ReadLine());
            Console.WriteLine("After Removing element...........");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == rem)
                {
                    continue; 
                }
                Console.WriteLine(arr[i]);

            }



            //Console.WriteLine("After...........");
            //for (int i = 0;i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            Console.ReadLine();
        }
    }
}
