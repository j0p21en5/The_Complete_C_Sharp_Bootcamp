using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_A_String_Using_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Jaykumar" };
            Console.WriteLine(arr.Length); 
            
            foreach (string i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
