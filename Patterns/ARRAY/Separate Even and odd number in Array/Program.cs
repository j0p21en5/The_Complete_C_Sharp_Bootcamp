using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Separate_Even_and_odd_number_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of element you want to store in Array : ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the Array elements  : ");

            for (int i = 0; i < arr.Length; i++)
            {
                int inp = int.Parse(Console.ReadLine());
                arr[i] = inp;
            }
            Console.Write("Even numbers Are : ");
            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i] %2== 0)
                {
                    Console.Write(" "+arr[i]);
                }
            }
            Console.WriteLine();
            Console.Write("Odd numbers are : ");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] %2!= 0)
                {
                    Console.Write(" " + arr[i]);
                }

            }

            Console.ReadLine();

        }
    }
}
