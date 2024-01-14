using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_all_zeros_to_the_Start_of_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 0, 8, 0, 3, 0, 4, 0 };
            int count = 0;
           
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    count++;
                    continue;
                }
                
            }
            Console.WriteLine("After moving all zero to the start");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(0);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    
                    continue;
                }
                Console.WriteLine(arr[i]);

            }

            Console.ReadLine();
        }
    }
}
