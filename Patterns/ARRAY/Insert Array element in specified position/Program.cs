using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_Array_element_in_specified_position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lenght of Array : ");
            int a = int.Parse(Console.ReadLine());
            int[] num = new int[a];


            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("Enter the index number :");
                int p = int.Parse(Console.ReadLine());

                Console.Write("Enter the Element :");
                int j = int.Parse(Console.ReadLine());
                num[p] = j;
            }


            Console.WriteLine("Your data :");
            foreach (int data in num)
            {
                Console.WriteLine(data);
            }
            Console.ReadLine();
        }
    }
}
