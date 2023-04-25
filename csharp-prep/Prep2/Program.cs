using System;
using System.Collections.Generic;

namespace gradeinput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your current grade in this class? ");
            string grade = Console.ReadLine();
            int number = int.Parse(grade);
            string lettergrade;

            if (number >=  90)
            {
                lettergrade = "A";
                //Console.Write("A");
            }
            else if (number >= 80 && number < 90)
            {
                lettergrade = "B";
                //Console.Write("B");
            }
            else if (number >= 70 && number < 80)
            {
                lettergrade = "C";
                //Console.Write("C");
            }
            else if (number >= 60 && number < 70)
            {
                lettergrade = "D";
                //Console.Write("D");
            }
            else if (number < 60)
            {
                lettergrade = "F";
                //Console.Write("F");
            }
            else
            {
                lettergrade = "";
            }

            float remainder;
            remainder = number % 10;

            // Console.WriteLine($"{remainder}");

            string sign;

            if (remainder >= 7 && number < 97 && number > 60)
            {
                sign = "+";
            }
                
            else if (remainder < 3 && number > 60)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }

            Console.Write($"{lettergrade}{sign}");

        }
    }
}
