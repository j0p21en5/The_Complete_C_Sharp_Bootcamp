using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_two_arrays_are_equal_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the element number you want to store in First Array : ");
            //int n1 = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[n1];

            //Console.WriteLine("Enter the First Array elements : ");
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    int b = int.Parse(Console.ReadLine());
            //    arr1[i] = b;
            //}


            //Console.WriteLine("Enter the element number you want to store in Second Array : ");
            //int n2 = int.Parse(Console.ReadLine());
            //int[] arr2 = new int[n2];


            //Console.WriteLine("Enter the First Array elements : ");
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    int c = int.Parse(Console.ReadLine());
            //    arr2[i] = c;
            //}

            //if(arr1 == arr2)
            //{
            //    Console.WriteLine("Arrays are same ");
            //}

            //else
            //{
            //    Console.WriteLine("They are not the same ");
            //}


            Console.Write("Enter the length of First Array : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of second Array : ");
            int b = int.Parse(Console.ReadLine());

            int[] num1 = new int[a];
            int[] num2 = new int[b];

            Console.WriteLine("Enter the first Array Element : ");
            for (int i = 0; i < num1.Length; i++)
            {
                int k = int.Parse(Console.ReadLine());
                num1[i] = k;
            }

            Console.WriteLine("Enter the second Array element : ");
            for (int i = 0; i < num2.Length; i++)
            {
                int p = int.Parse(Console.ReadLine());
                num2[i] = p;
            }

            if (num1 == num2)
            {
                Console.WriteLine("same...");
            }
            else
            {
                Console.WriteLine("not same....");
            }



            Console.ReadLine();
        }
    }
}
