using System;
using System.Collections.Generic;

namespace journal
{
    class Program
    {
        static void Main(string[] args)
        {
            //neatness
            Console.WriteLine("");

            Console.WriteLine("Welcome back to your Journal!");

            //Spacing
            Console.WriteLine("");

            // Console.WriteLine("Please select one of the following choices");
            // Console.WriteLine("1. Write");
            // Console.WriteLine("2. Display");
            // Console.WriteLine("3. Load");
            // Console.WriteLine("4. Save");
            // Console.WriteLine("5. Quit");  
            // //Spacing
            // Console.WriteLine("");
            // //User input
            // Console.Write("What would you like to do?");
            // string menu_choice =Console.ReadLine();

            //Intiating clsoeProgram variable
            string closeProgram = "active";

            //List of prompts
            var random = new Random();
            var prompts = new List<string>();
            string prompt1 = "How was the weather today?";
            prompts.Add(prompt1);
            string prompt2 = "What was the funnest thing you did today?";
            prompts.Add(prompt2);
            string prompt3 = "Tastiest thing you ate today?";
            prompts.Add(prompt3);
            string prompt4 = "Something pretty you saw today?";
            prompts.Add(prompt4);
            string prompt5 = "Something that surpirsed you today?";
            prompts.Add(prompt5);

            
            while (closeProgram != "end")
            {

                //Spacing
                Console.WriteLine("");

                Console.WriteLine("Please select one of the following choices");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");  
                //Spacing
                Console.WriteLine("");

                //User input
                Console.Write("What would you like to do? ");
                string menu_choice =Console.ReadLine();

                //Spacing
                Console.WriteLine("");

                if (menu_choice == "1")
                {
                    int index = random.Next(prompts.Count);
                    System.Console.WriteLine(prompts[index]);

                    Console.WriteLine("");
                    Console.Write(">> ");
                    string entry1 = Console.ReadLine();

                }

                else if (menu_choice == "2")
                {
                    Console.WriteLine($"{entry1}")
                    
                }

                else if (menu_choice == "3")
                {
                    
                }

                else if (menu_choice == "4")
                {
                    
                }

                else if (menu_choice == "5")
                {
                    Console.Write("Have a great day!");
                    closeProgram = "end";
                }
            }

        }
    }
}