using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_element_from_an_array_by_index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr= { 1, 2, 3 ,4,5 };
            int n = 2;
            for(int i = 0; i < arr.Length; i++)
            {
                if(i == n)
                {
                    continue;
                }
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
