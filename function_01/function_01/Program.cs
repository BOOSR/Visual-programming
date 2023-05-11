using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_01
{
    class Program
    {

        static int Volume(int h, int l,int w)
        {
            int result=( + h * l * w);
            return result;
        }
        static int Area(int h,int l,int w)
        {int area=(((l*h)*2)+ ((l * w) * 2) + ((w * h) * 2));
            return area;
        }
        static int PerameterOpened(int l )
        {
            
            return l*12;
        }
        static int PerameterCloesd(int l,int h,int w)
        {
            int result=2*l+10*w + 16 * h;
            return result;
        }
        static void Main(string[] args)
           {

            Console.WriteLine("Please Enter Dimantions");
            Console.Write("Hight = ");
            int hight =Convert.ToInt32(Console.ReadLine());

            Console.Write("lenth = ");
            int lenth = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("width = ");
            int width = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\n---------------------------------------------");


            Console.WriteLine($"Volume is :{Volume (hight, lenth, width) }");

            Console.WriteLine($"Area is : {Area (hight, lenth, width) }");
            
            Console.WriteLine($"Perameter Opened is :{PerameterOpened( lenth) }");
            
            Console.WriteLine($"Perameter Cloesd is :{PerameterCloesd(hight, lenth, width) }");

            Console.WriteLine("---------------------------------------------");



            Console.Read();



        }
    }
}
