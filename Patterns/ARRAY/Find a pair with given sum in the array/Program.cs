using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_a_pair_with_given_sum_in_the_array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 5, 7, 85, 64, 12, 6};
            int sum = 18;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1;j<arr.Length; j++)
                {
                    if (arr[i] + arr[j] == sum)
                    {
                        Console.WriteLine(arr[i]+" , " + arr[j]);
                        
                    }
                    
                    
                }
                
                
                
            }
            Console.ReadLine();
        }
    }
}
