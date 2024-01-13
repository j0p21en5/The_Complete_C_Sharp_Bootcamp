using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_one_array_is_a_subset_of_another_array_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 5,56,42,};
            int[] arr2 = { 1, 2, 3, 4, 5, 6, 7 };

            int count = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        count++;
                    }
                }
            }
            if(count == arr2.Length)
            {
                Console.WriteLine("Second Array is the subset of first Array ...");

            }
            else if (count == arr1.Length)
            {
                Console.WriteLine("First array is subset of second Array ");
            }
            else
            {
                Console.WriteLine( "Here no subset is present of Any Array... ");
            }

            Console.ReadLine();
        }
    }
}
