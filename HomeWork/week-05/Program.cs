using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_05
{
    class Program
    {
    static    double final;
       static int  time_to_reach_goal(double initial_amount, double interest_rate, double goal_amount)
        {
            int years = 0;
            while (initial_amount < goal_amount)
            {
                double interest = initial_amount * interest_rate;
                initial_amount += interest;
                years++;
            }
            final = initial_amount;
            return years;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is your current balance?");
            double initial_amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your current annul intrest (in %)?");
            double interest_rate =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("what balance would you like To have?");
            double goal_amount;
            do
            {
                goal_amount = Convert.ToDouble(Console.ReadLine());
                if (goal_amount < initial_amount)
                {
                    Console.WriteLine("You must enter an amount greater then your current balance!" +
                        "\nplease enter another value.");
                }
                else break;
            } while (goal_amount < initial_amount);


            int years = time_to_reach_goal(initial_amount, interest_rate, goal_amount);

            Console.WriteLine("In {0} years you'll have a balance of {1}", years,final);
            Console.ReadLine();
        }

    }
}
