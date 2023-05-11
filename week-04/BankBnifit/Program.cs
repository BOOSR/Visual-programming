using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBnifit
{
    class Program
    {
        static void Main(string[] args)
        {
            double blc, bg, bb;
            int monts_Waite = 0;
            Console.WriteLine("enter blance");
            blc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter Gold");
            bg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter bank benifite");
            bb = Convert.ToDouble(Console.ReadLine());

            while (blc <= bg)
            {
                blc = (blc * (bb / 100)) + blc;
                monts_Waite++;
           
            }
            Console.Write("your blance after\t" + monts_Waite + "\t is \t" + blc);
            // Console.Write("your blance after one month: ");
            // bg = (blc * (bb / 100)) + blc;
            Console.Write("number of mounths they should waite is \t" + monts_Waite);
            Console.ReadLine();


        }
    }
}
