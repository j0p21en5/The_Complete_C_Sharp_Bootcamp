using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_missing_numbers_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,6,7 };

            int temp  = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0;j<arr.Length-1; j++)
                {
                    if (arr[j] == arr[j+1])
                    {
                        temp = arr[j + 1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;
                    }
                }

              
            }
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
