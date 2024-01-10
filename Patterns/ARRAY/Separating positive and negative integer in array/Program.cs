using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Separating_positive_and_negative_integer_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of element you want to store in array : ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the Array elements : ");
            for (int i = 0; i < n; i++)
            {
                int inp = int.Parse(Console.ReadLine());
                arr[i] = inp;
            }
            Console.Write("Positive Interger Are : ");

            for(int i = 0;i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    Console.Write(" "+arr[i]);

                }

            }
            Console.WriteLine();

            Console.Write("Negative Integer Are : ");

            for (int i = 0; i <arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    Console.Write(" " + arr[i]);
                }

            }
            Console.ReadLine();
        }
    }
}

