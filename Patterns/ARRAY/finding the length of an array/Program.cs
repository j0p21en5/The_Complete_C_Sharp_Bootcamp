using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finding_the_length_of_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            int len =0 ;

            //for (int i = 0; i < len+1; i++)
            //{
            //    //if (arr[i] == null)
            //    //{
            //    //    break;
            //    //}
            //    len++;
            //}
            foreach (int i in arr)
            {
                len++;
            }
            Console.WriteLine("Length of Array is ; "+len);
            Console.ReadLine();
        }
    }
}
