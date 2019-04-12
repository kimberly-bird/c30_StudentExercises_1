using System;
using System.Collections.Generic;

namespace studentEx1
{
    public class Cohort
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Instructor> Instructors { get; set; } = new List<Instructor>();

        // constructor
        public Cohort (string name) 
        {
            Name = name;
        }

        public Cohort()
        {

        }

        public override string ToString() {
            return $@"
            ";
        }


    }
}