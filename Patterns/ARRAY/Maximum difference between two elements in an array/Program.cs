using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_difference_between_two_elements_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements you want to store in array : ");
            int num= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Array elements : ");
            int[] arr = new int[num];
            for (int i = 0; i < num; i++)
            {
                int inp  = int.Parse(Console.ReadLine());
                arr[i] = inp;
            }

            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
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
            int large = arr[arr.Length - 1];
            int n = large - small;
            //int n = arr[arr[arr.Length-1] -arr[0]];
            Console.WriteLine("The max differenc b/w to elements is : "+n);
            Console.ReadLine();
        }
    }
}
