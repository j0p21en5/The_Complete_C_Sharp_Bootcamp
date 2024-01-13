using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversing_Array_using_Swapping_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4, 5, 6 };

            int temp= arr.Length;
            int temp2;


            while (temp >= 0)
            {
                for (int j = 0; j < temp - 1; j++)
                {
                    temp2 = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp2;
                }
                temp--;
            }
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
