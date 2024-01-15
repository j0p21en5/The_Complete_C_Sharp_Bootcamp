using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_of_sum_of_all_array_element
{
    //class arrsum
    //{
        

        
    //}
    internal class Program
    {
        
        
        public int[] arr = new int[5];
        public void inpfun()
        {
            Console.WriteLine("Enter Aray element : ");
            for (int i = 0; i < arr.Length; i++)
            {

                int inp = int.Parse(Console.ReadLine());
                arr[i] = inp;
            }

        }

        public int sum = 0;

        public void sumfun()
        {
            foreach (int item in arr)
            {
                sum = sum + item;
            }
            Console.WriteLine("sum is : " + sum);
        }
        static void Main(string[] args)
        {

            Program obj = new Program();
            obj.inpfun();
            obj.sumfun();

            Console.ReadLine();
        }
    }
}
