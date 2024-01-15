using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_For_find_Smallest_And_Largest_Element_in_The_Array
{
    class Findmaxmin
    {
        public int[] arr = new int[5];

        public void inparr()
        {
            Console.WriteLine("Enter the Array elements : ");
            for (int i = 0; i < arr.Length; i++)
            {
                int p = int.Parse(Console.ReadLine());
                arr[i] = p;
            }

        }

        public void smallest()
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] >= arr[j + 1])
                    {
                        temp = arr[j+1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;

                    }
                }
            }

            Console.WriteLine("The smallest elements is : " + arr[0]);
        }
        public void largest()
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] >= arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;

                    }
                }
            }

            Console.WriteLine("The Largest elements is : " + arr[arr.Length-1]);
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Findmaxmin maxmin = new Findmaxmin();
            maxmin.inparr();
            maxmin.smallest();
            maxmin.largest();

            Console.ReadLine();
        }
    }
}
