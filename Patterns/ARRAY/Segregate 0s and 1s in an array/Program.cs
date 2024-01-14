using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segregate_0s_and_1s_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 0, 0, 1, 1, 1, 0, 0 };

            int count = 0;

            Console.WriteLine("After segregate 0s and 1s in an Array, Array is : ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    count++;
                    continue;
                }
                Console.WriteLine(arr[i]);
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(1);
            }

            Console.ReadLine();
        }
    }
}
