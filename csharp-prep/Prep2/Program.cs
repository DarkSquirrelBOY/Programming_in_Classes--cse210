using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your current grade in this class? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        if (number > 90)
        {
            Console.WriteLine("A");
        }
    }
}