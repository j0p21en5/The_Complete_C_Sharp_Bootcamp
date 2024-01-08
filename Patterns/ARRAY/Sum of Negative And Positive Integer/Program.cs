using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Negative_And_Positive_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you Want to store in Array : ");
            int n = int.Parse(Console.ReadLine());
            int sump = 0;
            int sumn = 0;
            int[] arr = new int[n];
            Console.WriteLine("Enter The array Elements : ");
            for (int i = 0; i < arr.Length; i++)
            {
                int b = int .Parse(Console.ReadLine());
                arr[i] = b;
            }
            Console.WriteLine("Array Elements Are : ");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i]>0)
                {
                    sump= sump + arr[i];


                }
                else
                {
                     sumn= sumn + arr[i];
                }
            }
            Console.WriteLine("The sum of positive number is : "+sump);
            Console.WriteLine("The sum of negative  number is : " + sumn);

            Console.ReadLine();
        }
    }
}
