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

            if (number >=  90)
            {
                Console.WriteLine("A");
            }
            else if (number >= 80 && number < 90)
            {
                Console.WriteLine("B");
            }
            else if (number >= 70 && number < 80)
            {
                Console.WriteLine("C");
            }
            else if (number >= 60 && number < 70)
            {
                Console.WriteLine("D");
            }
            else if (number < 60)
            {
                Console.WriteLine("F");
            }
        }
    }
}
