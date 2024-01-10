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
            Console.WriteLine("Enter the number of element you want to store in Array");
            int n = int.Parse(Console.ReadLine());

            int etc = n + 1;

            int[] arr = new int[etc];

            Console.WriteLine("Enter the Array Elements : ");

            for (int i = 0; i < arr.Length-1; i++)
            {
                int inp = int. Parse(Console.ReadLine());
                arr[i] = inp;
            }

            Console.WriteLine("elements Are : ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }
            //for element 

            Console.WriteLine("Enter element to insert in Array : ");
            int ins = int.Parse(Console.ReadLine());

            //for position

            Console.WriteLine("Enter the index position to insert element : ");
            int pos = int.Parse(Console.ReadLine());

            for (int i = arr.Length - 1; i >= pos - 1; i--) 
            {
                arr[i + 1] = arr[i];
                arr[pos - 1] = ins;

            }
                
            Console.WriteLine("After insert");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }



            //Console.Write("Enter the lenght of Array : ");
            //int a = int.Parse(Console.ReadLine());
            //int[] num = new int[a];


            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.Write("Enter the index number :");
            //    int p = int.Parse(Console.ReadLine());


            //}


            //Console.WriteLine("Your data :");
            //foreach (int data in num)
            //{
            //    Console.WriteLine(data);
            //}




            Console.ReadLine();
        }
    }
}
