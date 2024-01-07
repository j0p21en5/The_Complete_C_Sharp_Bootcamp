using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Pattern4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int num ;
            Console.WriteLine("Enter the number");
            num = int.Parse(Console.ReadLine());
            int n = num-1;
            
            for (int  i = 0; i < num; i++)
            {

                
                for (int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();

            }
            

            //for (int i = 1; i <= num; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            Console.ReadLine();
        }
    }
}
