using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern7
{
    internal class Program
    { 
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            int s = n - 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= s; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                //for(int j = 2; j <= i; ++j)
                //{
                //    Console.Write("*");

                //}
                Console.WriteLine();
            }

            for (int i = 2; i <= n; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k <= n; k++)
                {
                    Console.Write("*");
                }
                //for (int k = i; k <= s; k++)
                //{
                //    Console.Write("*");
                //}
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
