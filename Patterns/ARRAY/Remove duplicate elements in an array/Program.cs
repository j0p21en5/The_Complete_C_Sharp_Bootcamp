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
            Console.WriteLine("eneter the you want to store in array ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter Array elements : ");
            for (int i = 0; i < arr.Length; i++)
            {
                int b = int.Parse(Console.ReadLine());
                arr[i] = b;
            }
            Console.WriteLine("After......");
            for (int i = 0;i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] != arr[j])
                    {
                        Console.WriteLine(arr[i]);
                    }
                    else
                    {
                        continue;
                    }
                } 

                    
                        
                
            }
            //Console.WriteLine("After......");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);

            //}

            


            Console.ReadLine();
        }
    }
}
