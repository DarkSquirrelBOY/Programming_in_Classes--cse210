using System;
using System.Collections.Generic;

namespace abstractionlearning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Spacing
            Console.WriteLine("");
            

            //First Job info
            Job job1 = new Job();
            //--//
            job1._company = "Edwards Finishing";
            job1._jobTitle = "Carpenter";
            job1._startYear = 2022;
            job1._endYear = 2023;

            //Second Job info
            Job job2 = new Job();
            //--//
            job2._company = "Victory";
            job2._jobTitle = "Furniture home delivery contractors";
            job2._startYear = 2021;
            job2._endYear = 2021;


            Resume myResume = new Resume();
            myResume._name = "Caden S. Davis";
            myResume._jobs.Add(job1);
            myResume._jobs.Add(job2);
            
            //Resume Display
            myResume.DisplayResume();




            //Spacing
            Console.WriteLine("");
        }
    }

}