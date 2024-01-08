using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int sum = 0;
            Console.WriteLine("Enter Five Students Marks : ");

            for (int i = 0; i < arr.Length; i++)
            {
                int b = int.Parse(Console.ReadLine());
                arr[i] = b;
            }
            Console.WriteLine("Five Students Marks Is : ");
            for(int i = 0;i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                sum = sum + arr[i];
            }

            double avg = sum / 5;
            Console.WriteLine("Average Marks Is : "+avg);
            Console.ReadLine();
        }
    }
}
