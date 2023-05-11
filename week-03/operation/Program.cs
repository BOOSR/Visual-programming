using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operation
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter Your age :");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are "+( (age < 30 ) && (age>20))+ " yaung");
            Console.WriteLine("You are "+ ((age > 30 )&&(age<50)) +" middle man");
            Console.WriteLine("You are "+ ( (age == 30 )||(age<=20))+" ok ");

            Console.ReadLine();
        }
    }
}
