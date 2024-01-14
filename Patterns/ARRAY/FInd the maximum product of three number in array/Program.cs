using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInd_the_maximum_product_of_three_number_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 5, 6, 41, 2, 5, 1, 2, };
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] >= arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            int product = arr[arr.Length-3] *arr[arr.Length - 2] * arr[arr.Length - 1];
            Console.WriteLine("Pair with maximum product in array is : "+ arr[arr.Length - 3] + " , " + arr[arr.Length - 2] + " , " + arr[arr.Length - 1] + " = " + product);
            Console.ReadLine();
        }
    }
}
