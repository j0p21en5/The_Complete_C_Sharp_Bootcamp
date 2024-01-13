using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Smallest_And_Largest_Element_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 25, 65, 47, 5, 85 };

            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0;j<arr.Length-1;j++)
                {
                    if (arr[j] >= arr[j+1])
                    {
                        temp = arr[j + 1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;

                    }

                }
            }
            int small = arr[0];
            int large = arr[arr.Length-1];

            Console.WriteLine( "The samllest Element in the Array is : " + small);

            Console.WriteLine("The Largest Element in the Array is : " + large);
            
            Console.ReadLine();
        }
    }
}
