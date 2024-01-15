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
            int[] arr = { 54, 24, 3, 42, 5, 6, 21, 2, 54, };

            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0;j<arr.Length-1; j++)
                {
                    if (arr[j] - arr[j+1] >= temp ) 
                    {
                        Console.WriteLine(arr[j] +" " + arr[j+1]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
