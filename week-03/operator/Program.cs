using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Namespace2;
//using static System.Console;
namespace namespace1
{
    class C1
    {
        public void f1()
        {
            Console.WriteLine("you are in  \"Namespace1\" \"1\" and Class \"C1\" and function \"f1\"");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

           namespace1.C1 obj = new namespace1.C1();
            Namespace2.C1 obj2 = new Namespace2.C1();
            
            obj.f1();
            obj2.f1();
            Console.ReadLine();

            //  int v1 = 3, v2 = 5, v3 = 7;
            //int re;

            ////re = (v1++ - v2) + (--v3 * (v2 / v1));
            ////Console.WriteLine($" v1:{v1} \n v2:{v2} \n v3:{v3} \n {re}");
            ////Console.ReadLine();
            //string ans;
            //Console.WriteLine("ENter your name :");
            //ans = Console.ReadLine();
            //Namespace2.A.print(ans);
            //Console.ReadLine();

        }
    }
}
namespace Namespace2 {
    class C1
    {
        public void f1()
        {
            Console.WriteLine("you are in  \"Namespace2\" \"2\" and Class \"C1\" and function \"f1\"");
        }
    }
    //class A
    //    {
    //        static public void print(string x)
    //        {
    //            Console.WriteLine(x);
    //        }
    //    }
}

