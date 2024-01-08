using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number : ");
            int n = int.Parse(Console.ReadLine());
            int s = n - 1;
            int t = n - 2;

            for (int i = 0; i < n; i++)
            {
                Console.Write("*");

            }
            Console.WriteLine();
            for (int i = 0;i < s; i++)
            {
                Console.Write("*");
                for (int j = i; j < t; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
