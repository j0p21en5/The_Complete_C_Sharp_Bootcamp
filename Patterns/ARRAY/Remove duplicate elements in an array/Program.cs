using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_duplicate_elements_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("eneter the you want to store in array ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];

            //Console.WriteLine("Enter Array elements : ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int b = int.Parse(Console.ReadLine());
            //    arr[i] = b;
            //}
            //Console.WriteLine("After......");
            //for (int i = 0;i < arr.Length; i++)
            //{
            //    for (int j = i+1; j < arr.Length; j++)
            //    {
            //        if (arr[i] != arr[j])
            //        {
            //            Console.WriteLine(arr[i]);
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //    } 




            //}



            //Console.WriteLine("After......");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);

            //}


            //Console.Write("Enter the length of Array : ");
            //int a = int.Parse(Console.ReadLine());

            //int[] num = new int[a];

            //Console.WriteLine("Enter the element : ");
            //for (int i = 0; i < num.Length; i++)
            //{
            //    int b = int.Parse(Console.ReadLine());
            //    num[i] = b;
            //}
            //Array.Sort(num);
            //int j = 0;
            //for (int i = 0; i < num.Length - 1; i++)
            //{
            //    if (num[i] != num[i + 1])
            //    {
            //        num[j++] = num[i];
            //    }
            //}
            //num[j++] = num[num.Length - 1];

            //Console.WriteLine("After removing duplicate element from array:");

            //for (int i = 0; i < j; i++)
            //    Console.Write(" " + num[i]);


            //Console.WriteLine("eneter the you want to store in array ");
            //int n = int.Parse(Console.ReadLine());
            int[] arr = {1,2,2,3,4,4};
            int[] temp = new int[arr.Length];

            int j = 0;

            


            //Console.WriteLine("Enter Array elements : ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int b = int.Parse(Console.ReadLine());
            //    arr[i] = b;
            //}
            Console.WriteLine(".........");
            Array.Sort(arr);

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    temp[j++] = arr[i];
                }

            }
            temp[j++] = arr[arr.Length-1];
            for (int i = 0;i < j; i++)
            {
                Console.WriteLine(temp[i]);
            }
            



            Console.ReadLine();
        }
    }
}
