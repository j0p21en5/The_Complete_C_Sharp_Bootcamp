using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Number_Of_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 5, 2, 3,3,3 };
            
            Console.WriteLine("Enter A to find Count : ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    count++;
                }

            }
            Console.WriteLine("The Number is Count : "+count);
            Console.ReadLine();

        }
    }
}
