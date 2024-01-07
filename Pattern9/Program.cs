using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            for (int i = 0; i < n; i++)
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



            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }


                
                Console.Write("*");
                for (int j = i; j < 4; j++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j < 4; j++)
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
