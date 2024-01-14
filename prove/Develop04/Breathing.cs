using System;
namespace Develop04
{
    public class Breathing : Activities
    {
        private int BreathIn , BreathOut = 0;

        public Breathing(int userSeconds)
        {
            Console.Write("How long would you like your Breathing Activity to last (in seconds)? ");
            int userSeconds = Console.ReadLine("");
        }

        private void SplitTime(int seconds)
        {

            //Math Stuff
            BreathIn = 0;
            BreathOut = 0;
        }
    }
}