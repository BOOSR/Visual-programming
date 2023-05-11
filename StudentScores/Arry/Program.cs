using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arry
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] math1 = new int[3, 4];
            int[,] math2 = new int[4, 2] { { 2, 3 }, { 4, 5 }, { 1, 7 },{ 0, 9 } };
            int[,] math3 = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };

            for (int i = 0; i < math1.GetLength(0); i++)
            {
                Console.WriteLine("Enter the number  of row {0}", i);
                for (int j = 0; j < math1.GetLength(1); j++)
                {
                    Console.WriteLine("math1[{0},{1}]\t", i,j);
                    math1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for ( int i=0;i<math1.GetLength(0); i++)
            {

                for ( int j = 0; j < math1.GetLength(1); j++)
                {
                    Console.Write(math1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("+++++++++++++");

            int[,]test= new int[3,3];
            //foreach سطر به سطر
            int counter = 0;
            foreach (int a in math3)
            {
                counter++;
                foreach(int b in a)
                {
                    counter = 0;
                    Console.Write( b + '\t');

                }

            }

            Console.WriteLine("\n____________________");

            for (int i = 0; i < math2.GetLength(0); i++)
            {
                for (int j = 0; j < math2.GetLength(1); j++)
                {
                    Console.Write(math2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
          
        }
    }
}
