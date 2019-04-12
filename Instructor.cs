using System;
using System.Collections.Generic;

namespace studentEx1
{
    public class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }

        // constructor
        public Instructor (string firstName, string lastName, string slackHandle, Cohort cohort)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
        }

        public Instructor ()
        {
            
        }

        // Assign an exercise to a student


    }
}