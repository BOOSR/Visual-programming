using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Question
{
    class Program
    {
        static void facto(int n)
        {
            int sum = 1;
            for (int i = 0; i < n; i++)
                sum += i * sum;
            Console.WriteLine($"fac{n} :{sum}");
        }
      
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number :");
            int n = Convert.ToInt32(Console.ReadLine());
            facto(n);
            Console.Read();

        }
    }
}
