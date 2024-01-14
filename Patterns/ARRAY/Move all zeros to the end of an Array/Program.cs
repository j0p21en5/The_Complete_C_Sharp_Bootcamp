using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Move_all_zeros_to_the_end_of_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 32, 6, 0, 4, 0,0,0 };
            int count=0 ;
            Console.WriteLine("After all zero in the end...");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    count++;
                    continue;
                    
                }
                Console.WriteLine(arr[i]);

            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(0);
            }
            
            


            Console.ReadLine();
        }
    }
}
