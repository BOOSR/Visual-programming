using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Question
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the length of Array:");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[length];
            int i = 0;
            for ( i = 0; i < length; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write("Enter the length of Array:");
             length = Convert.ToInt32(Console.ReadLine());
            int[] array2 = new int[length];
            for (i = 0; i < length ; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());

            }

            int[] result = new int[array1.Length + array2.Length];
   
           
            int j = 0;
            i = 0;
            int h = 0;
            while (h < result.Length)
            {
                if (i < array1.Length)
                {
                    result[h++] = array1[i++];
                }
                

                if (j < array2.Length)
                {
                    result[h++] = array2[j++];
                }
                  
            }
            
            Console.WriteLine("Merged array: ");
            for (i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.Read();


        }
    }
}
