using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Or_Not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check : ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                //Console.WriteLine(i);

                if (n % i == 0)
                {
                    count++;

                }

            }
            if (count == 1)
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
