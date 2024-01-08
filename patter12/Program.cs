using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace patter12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter the number : ");
            //int n = int.Parse(Console.ReadLine());
            //int s = n - 1;
            //int t = n - 2;
            //int q = n + 1;

            //for (int i = 0; i < s; i++)
            //{
            //    for (int j = i; j < s; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    Console.Write("*");

            //    for (int k = 0; k < i; k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k < i; k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.Write("*");
            //    Console.WriteLine();

            //}
            //for (int i = 0; i < q; i++)
            //{
            //    Console.Write("*");
            //    Console.Write(" ");

            //}

            int n = 12;
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                Console.WriteLine(i);

                if(n%i == 0)
                {
                    count++;

                }

            }
            if(count == 1)
            {
                Console.WriteLine("it is not prime");
            }
            else
            {
                Console.WriteLine("it is prime");
            }
            Console.ReadLine();
        }
    }
}
