using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patter12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 0; i < 4; i++)
            {
                for (int j = i; j < 4; j++)
                {
                    Console.Write(" ");
                }
                
                Console.Write("*");

                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine();

            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("*");

            }
            Console.ReadLine();
        }
    }
}
