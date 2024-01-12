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






            Console.WriteLine("Enter the element number you want to store in First Array : ");
            int n1 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n1];

            Console.WriteLine("Enter the First Array elements : ");
            for (int i = 0; i < arr1.Length; i++)
            {
                int b = int.Parse(Console.ReadLine());
                arr1[i] = b;
            }


            Console.WriteLine("Enter the element number you want to store in Second Array : ");
            int n2 = int.Parse(Console.ReadLine());
            int[] arr2 = new int[n2];


            Console.WriteLine("Enter the second Array elements : ");
            for (int i = 0; i < arr2.Length; i++)
            {
                int c = int.Parse(Console.ReadLine());
                arr2[i] = c;
            }


            Array.Sort(arr1);
            Array.Sort(arr2);

            int count = 0;

            for (int i = 0; i < n1; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    count++;
                }
            }
            if (arr1.Length == arr2.Length)
            {

                if (n1 == count)
                {
                    Console.WriteLine("Same");
                }
                else
                {
                    Console.WriteLine("Different");
                }
            }
            else
            {
                Console.WriteLine("different");
            }
            //if(arr1 == arr2)
            //{
            //    Console.WriteLine("Arrays are same ");
            //}

            //else
            //{
            //    Console.WriteLine("They are not the same ");
            //}






            Console.ReadLine();
        }
    }
}
