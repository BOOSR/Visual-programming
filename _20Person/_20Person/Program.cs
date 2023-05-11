using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of Array:");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            int i;
            for (  i = 0; i < length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            
            }

           int  j, temp;
            bool swapped;
            for (i = 0; i < array.Length - 1; i++)
            {
                swapped = false;
                for (j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                 
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;
            }
            for ( i = 0; i < length; i++)
            {
                Console.Write(array[i]);
            }
            Console.Read();
        }
    }
}
