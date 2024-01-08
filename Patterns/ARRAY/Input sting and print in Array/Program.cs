using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_sting_and_print_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to store in array string : ");
            int n  = int.Parse(Console.ReadLine());

            string[] arr = new string[n];
            Console.WriteLine("Input the String : ");
            for (int i = 0;i<arr.Length;i++)
            {
                string b =(Console.ReadLine());
                arr[i] = b;
            }
            Console.WriteLine("Strings Are : ");
            foreach(string i in arr)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
