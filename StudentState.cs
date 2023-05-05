using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your persont(%):");
            int pesont=Convert.ToInt32( Console.ReadLine());

            Console.Write("Enter Your Credit which passed :");
            int credit = Convert.ToInt32(Console.ReadLine());
            string str= "";
            if (credit < 55)
                str = "bad";
            if (credit <= 75)
                str = "middle";
            else if(credit <= 85)
                str = "good";
            else if ( credit <= 90)
               str = "very good";
          else if ( credit <= 100)
                str = "greed";
            int semester=0;
            int sem =credit;
            if (sem < 19 )
                semester = 1;
            else if (sem < 34 )
                semester = 2;
           else if (sem < 51 )
                semester = 3;
           else if (sem < 68 )
                semester = 4;
           else if (sem < 85 )
                semester = 5;
           else if (sem < 102 )
                semester = 6;
           else if (sem < 119  )
                semester = 7;
           else if (sem < 136 )
                semester = 8;
            string op = "";
            if (semester < 4 )
                op = "You have a lot of excess compensation.";
            else if (semester < 6 )
                op = "You have little compensation.";
            else if (semester < 8 )
                op = "You have no compensation .";

           Console.WriteLine("your semester is "+semester);
            Console.WriteLine("your persent is "+ str);
            Console.WriteLine(op);
            Console.ReadLine();




        }
    }
}
