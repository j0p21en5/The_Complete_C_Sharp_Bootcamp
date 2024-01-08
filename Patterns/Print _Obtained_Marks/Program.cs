using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Print__Obtained_Marks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 Students Marks : ");
            for (int i = 0; i < 5; i++)
            {
                
                Console.Write("Enter {0} Index Student Mark : ",i);
                int b = int.Parse(Console.ReadLine());
                arr[i] = b;
            }
            Console.WriteLine("The Marks Obtained By Student Are : ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("The Marks Obtained By Student is :  "+arr[i]);
            }

            Console.ReadLine();
        }
    }
}
