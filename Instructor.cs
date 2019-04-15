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

        public string FullName {
            get {
                return FirstName + " " + LastName;
            }
        }

        // Assign an exercise to a student
        public void AssignExercise(Student s, Exercise e)
        {
            // take the excerise and assign it to the student's list of exercises
            s.Exercises.Add(e);
        }


    }
}









