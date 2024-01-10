using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_frequency_of_all_numbers_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements you want to store in array : ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the Array elements : ");

            for (int i = 0; i < arr.Length; i++)
            {
                int inp = int.Parse(Console.ReadLine());
                arr[i] = inp;
            }
            Array.Sort(arr);
            
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;

                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }


                }
                
                Console.WriteLine(arr[i] + " Count in" + count + " Times");

            }
            
            
            Console.ReadLine();
        }
    }
}
