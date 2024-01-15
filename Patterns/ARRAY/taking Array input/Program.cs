using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace taking_Array_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of array ; ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter array element :");
            for (int i = 0; i < arr.Length  ; i++)
            {
                int p = int.Parse(Console.ReadLine());
                arr[i] = p;
                
            }

            


            Console.ReadLine();
        }
    }
}
