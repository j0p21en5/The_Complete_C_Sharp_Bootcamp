using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Of_N_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to store in Array : ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n]; 

            Console.WriteLine("Enter the Array elements ; ");

            for (int i = 0; i < arr.Length; i++)
            {
                int b = int.Parse(Console.ReadLine());
                arr[i] = b;

            }
            Console.WriteLine("Array elements Are : ");
        }
    }
}
