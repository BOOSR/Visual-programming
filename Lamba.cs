using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMLamba
{
    class Program
    {
        static int sum(int a, int b) => a + b;
        static int minis(int a, int b) => a - b;
        static double devide(double a, double b) =>Convert.ToDouble( a/b);
        static int multyplex(int a, int b) => a * b;

        static void Main(string[] args)
        {
            int x=10, y = 5;
            int  s = sum(x, y);
            int miniss = minis(x, y);
            double devid = devide(x, y);
            int mul = multyplex(x, y);
            Console.WriteLine( $"{x} + {y} : {s}");
            Console.WriteLine( $"{x} - {y} : {miniss}");
            Console.WriteLine( $"{x} / {y} : {devid}");
            Console.WriteLine( $"{x} * {y} : {mul}");
         
            Console.ReadKey();
        }
    }
}
