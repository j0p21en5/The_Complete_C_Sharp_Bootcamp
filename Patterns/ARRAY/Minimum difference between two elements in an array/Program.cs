using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_difference_between_two_elements_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9 ,1, 8, 11, 13 };

            
            int i, j;
            
            int Min_diff = 0;






        
            for (i = 0; i < arr.Length - 1; i++)
            {
                for (j = i + 1; j < arr.Length; j++)
                {
                    if ((arr[j] - arr[i]) < Min_diff)
                    {
                        Min_diff = (arr[j] - arr[i]);
                    }
                }
            }

            Console.WriteLine("Minimum difference between two Element is "+ Min_diff);

            Console.ReadLine();
        }
    }
}
