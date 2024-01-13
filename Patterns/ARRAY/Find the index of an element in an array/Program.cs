using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_index_of_an_element_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 ,5,6,8};

            int n = 2;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    Console.WriteLine("Search element "+n+" Index is "+i);
                }
            }
            Console.ReadLine();
        }
    }
}
