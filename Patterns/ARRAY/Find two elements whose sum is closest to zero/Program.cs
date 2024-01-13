using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_two_elements_whose_sum_is_closest_to_zero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 65, 4, 2, 41, 21, 1 };

            int sum;

            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    sum  = arr[i] + arr[j];
                }
            }
        }
    }
}
