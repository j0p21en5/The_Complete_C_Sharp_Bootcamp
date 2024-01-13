using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_two_arrays_are_the_disjoint_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 5, 25 };
            int[] arr2 = { 4,65,55,45,1 };

            int count = 0; 
             
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        count++; 
                    }
                }
            }

            if(count== 0)
            {
                Console.WriteLine("This is disjoint...");
            }
            else
            {
                Console.WriteLine("This is not disjoint");
            }
            Console.ReadLine();
        }
    }
}
