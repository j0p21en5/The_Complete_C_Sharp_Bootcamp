using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_element_in_reverse_order
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the element number you want to store in Array : ");
            int n = int.Parse(Console.ReadLine()); 
            int[] arr = new int[n];

            Console.WriteLine("Enter the Array elements : ");
            for (int i = 0; i < arr.Length; i++)
            {
                int b = int.Parse(Console.ReadLine());
                arr[i] = b;
            }

            Console.WriteLine("The Reverse elements Are : ");

            

            Console.ReadLine();
        }
    }
}
