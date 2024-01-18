using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_missing_numbers_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 5, 6 };

            
            int i, j;
            
            int sum = 0;
            for (i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            int size2 = arr.Length + 1;
            int miss = (size2 * (size2 + 1)) / 2 - sum;
            Console.WriteLine("Missing num is : "+miss);
            

            Console.ReadLine();
        }
    }
}
