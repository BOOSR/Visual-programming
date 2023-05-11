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
            
            Console.Write("Enter the number of lesson's:");
            int s=Convert.ToInt32( Console.ReadLine());
            int[] score = new int[s];
            string[] lessons = new string[s];
            int sum = 0;
            double Avg = 0;
            for ( int i = 0; i < s; i++)
            {
                Console.Write("Enter Lesson's Name:");
                lessons[i] = Console.ReadLine();
             
                Console.Write("Enter lEssion's Score:");
                score[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < lessons.Length; i++)
            {
                sum += score[i];
            }
            Avg = (double)sum / s;

            Console.WriteLine("  Lessons   |  Score   |  Category |   state   |");
            Console.WriteLine("|-----------|----------|-----------|-----------|");
            for ( int i = 0; i < lessons.Length; i++)
            {
                Console.Write($"|{lessons[i]}    |{score[i]}        |");
               
                switch (lessons[i])
                {
                    case string t when t.StartsWith("prog"):
                        {
                            Console.Write($"PROGRAMING |{state(score[i])}       |\n");
                        }break;
                    case string t when t.StartsWith("math"):
                        {
                            Console.Write($"MATH       |{state(score[i])}       |\n");
                        }break;
                    case string t when t.StartsWith("islam"):
                        {
                            Console.Write($"GENERAL   |{state(score[i])}       |\n");
                        }break;
                }

            }
            Console.WriteLine("|-----------|----------|-----------|-----------|");
            Console.WriteLine($"|Avrage :{Avg}       ");


             string state(int number)
            {
                if (number <= 45)
                {
                    return "Bad " ;
                }
                else if (number>45 && number < 55)
                {
                    return "good";
                }
                else if (number <=100 && number >= 55)
                {
                    return "High";
                }
                return "error";
            }
 
            Console.ReadKey();
        }
    }
}
