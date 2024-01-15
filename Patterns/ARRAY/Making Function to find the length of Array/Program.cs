using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Function_to_find_the_length_of_Array
{
    class length
    {
        public int[] arr = {2,5,6,78,2,15,5};


        int count = 0;
        
        public void arrLength()
        {
            foreach (int i in arr)
            {
                count++;
            }
            Console.WriteLine("Length of Array is : "+count);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            length obj = new length();
            
            obj.arrLength();

            Console.ReadLine();
        }
    }
}
