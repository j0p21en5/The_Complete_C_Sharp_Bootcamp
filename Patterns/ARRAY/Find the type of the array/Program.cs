using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_type_of_the_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the element number you want to store in Array : ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter the Array elements : ");
            for (int i = 0; i < arr.Length; i++)
            {
                int b = int.Parse(Console.ReadLine());
                arr[i] = b;
            }

            int even = 0,odd = 0;

            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            if(even == arr.Length)
            {
                Console.WriteLine("It is even Array");
            }

            else if(odd == arr.Length)
            {
                Console.WriteLine("It is odd Array ");
            }
            else
            {
                Console.WriteLine("It is mixed Array ");
            }
            Console.ReadLine();
        }
    }
}
