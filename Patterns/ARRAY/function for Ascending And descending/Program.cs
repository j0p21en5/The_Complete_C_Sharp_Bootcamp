using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_for_Ascending_And_descending
{
    class ascdsc
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

        public void asc()
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

            Console.WriteLine("Array in ascending order is : ");

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }


        }

        public void desc()
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

            Console.WriteLine("Array in descending order is : ");
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);

            }





        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ascdsc arr = new ascdsc();
            arr.inparr();
            arr.asc();

            arr.desc();


            Console.ReadLine();
        }
    }
}
