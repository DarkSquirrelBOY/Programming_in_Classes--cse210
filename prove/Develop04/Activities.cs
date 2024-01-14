using System;

namespace Develop04
{
    public class Activities
    {
        
        //public string Description<List>;
        // public UserTimer<int>;

        public int counter = 24;

        public void LoadSpinner()
        {

            counter++;        
                switch (counter % 4)
                {
                    case 0: Console.Write("/"); break;
                    case 1: Console.Write("-"); break;
                    case 2: Console.Write("\\"); break;
                    case 3: Console.Write("|"); break;
                }
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                
            // int counter;
            // public ConsoleSpiner()
            // {
            //     counter = 0;
            // }
            // public void Turn()
            // {
                
            // }

        }

        public void SetTimer()
        {
            
        }

        public void StartMessage(string)
        {
            
        }

        public void EndMessage()
        {
            
        }

        public void LogData()
        {
            
        }

        public void Description(string)
        {
            
        }
    }

}
