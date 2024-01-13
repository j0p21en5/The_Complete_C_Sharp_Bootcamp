using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merging_two_unsorted_arrays_of_different_lengths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 5, 6, 7, 8, 9, 45 };

            int[] arr2 = { 6, 7, 3, 4, 98, 5, 32, 56, 85 };
            int n = arr1.Length + arr2.Length;
            int[] merge = new int[n];
            int k = 0,i = 0 , j = 0 ;
            
            for(k = 0; k<n; k++)
            {
                if (i < arr1.Length)
                {
                    merge[k] = arr1[i];
                    i++;
                    k++;
                   
                    
                }
                if (j < arr2.Length)
                {
                    merge[k] = arr2[j];
                    j++;
                    
                }
               
            }
            foreach(int m in merge)
            {
                Console.WriteLine(m);
            }
            Console.ReadLine();

        }
    }
}
