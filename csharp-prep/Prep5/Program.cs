using System;
using System.Collections.Generic;

namespace ListManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            DisplayWelcome();

            string username = PromptUserName();

            int usernumber = PromptUserNumber();

            int squarednumber = SquareNumber(usernumber);

            DisplayResults(username, squarednumber);


            void DisplayWelcome()
            {
                Console.WriteLine("Welcome to the Program!");
            }

            static string PromptUserName()
            {
                Console.Write("What is your name? ");
                string username = Console.ReadLine();
                return username;
            }

            static int PromptUserNumber()
            {
                Console.Write("What is your favorite number? ");
                string number = Console.ReadLine();
                int usernumber = int.Parse(number);
                return usernumber;
            }

            static int SquareNumber(int number)
            {
                int squarednumber = number * number;
                return squarednumber;
            }

            void DisplayResults(string username ,int usernumber)
            {
                Console.WriteLine($"{username}, the square of your number is {usernumber}");
            }
        }
    }
}
