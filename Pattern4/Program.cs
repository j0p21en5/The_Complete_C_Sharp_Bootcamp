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
            string spc = " ";
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {
                    

                    Console.Write("*");
                     

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
