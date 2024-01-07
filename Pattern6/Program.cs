using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            { 
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }

            for (int i = 2; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}
