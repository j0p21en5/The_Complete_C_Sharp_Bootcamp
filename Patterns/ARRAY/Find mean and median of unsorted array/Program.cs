using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_mean_and_median_of_unsorted_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 7, 5, 6, 2 };
            double sum = 0,mean;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];

            }

            mean= sum / arr.Length;


            Console.WriteLine("Mean Of The Array is : "+mean);
            Console.ReadLine();
        }
    }
}
