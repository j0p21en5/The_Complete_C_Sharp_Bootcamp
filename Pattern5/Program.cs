﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            int s = num - 1;

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("-");
                }



                //for (int j = i; j < num; j++)
                //{
                //    Console.Write("*");
                //}
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
