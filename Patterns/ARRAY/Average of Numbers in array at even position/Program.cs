using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_of_Numbers_in_array_at_odd_and_even_position
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number you want to store in Array : ");
            int n = int.Parse(Console.ReadLine());

            int even = 0, odd = 0;

            int[] arr = new int[n];
            Console.WriteLine("Enter the Array Elements : ");
            for (int i = 0; i < arr.Length; i++)
            {
                int b = int.Parse(Console.ReadLine());
                arr[i] = b;
            }
            Console.WriteLine("Array elements Are : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }

            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i]%2 == 0)
                {
                    even = even + arr[i];

                }
                else
                {
                    odd = odd + arr[i];
                }
                
            }

            Console.WriteLine("The sum of even elements is : "+even);
            Console.WriteLine("The sum of odd elements is : " + odd);
            Console.ReadLine();

        }
    }
}
