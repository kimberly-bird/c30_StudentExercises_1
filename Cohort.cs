using System;
using System.Collections.Generic;

namespace studentEx1
{
    public class Cohort
    {
        public string Name { get; set; }
        // These are lists of custom types that we created - so a list of Student types and a list of Instructor types
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Instructor> Instructors { get; set; } = new List<Instructor>();

        // constructor
        public Cohort (string name) 
        {
            Name = name;
        }

        // This is a constructor method that doesn't require anything to be passed in on creating an instance of a Cohort 
        public Cohort()
        {

        }

        public override string ToString() {
            return $@"{Name}";
        }


    }
}