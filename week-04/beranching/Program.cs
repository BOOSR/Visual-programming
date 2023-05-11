using System;

namespace beranching
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            char op;

            string reg;
            Console.WriteLine("enter request :");
            reg = Console.ReadLine();
           Array c= reg.Split('+', '-', '*', '/');
            Console.WriteLine(c);
            //Console.Write("Enter first number:");
            //a = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter first number:");
            //b = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter operator:");
            //op = Convert.ToChar(Console.ReadLine());

            //if (op == '+')
            //    Console.WriteLine(a + b);
            //else if (op == '-')
            //    Console.WriteLine(a - b);
            //else if (op == '*')
            //    Console.WriteLine(a * b);
            //else if
            //    (op == '/')
            //    if(b==0)
            //    Console.WriteLine(a / b);
            //else
            //    Console.WriteLine("error");


            //switch (op)
            //{
            //    case '+':
            //        Console.WriteLine(a + b);
            //        break;
            //    case '-':
            //        Console.WriteLine(a - b);
            //        break;
            //    case '*':
            //        Console.WriteLine(a * b);
            //        break;
            //    case '/':
            //        Console.WriteLine(a / b);
            //        break;
            //    default:
            //        Console.WriteLine("Error");
            //        break;
            //}

            Console.ReadLine();

            //fds
            //fds
        }
    }
}
