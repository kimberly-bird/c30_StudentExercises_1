using System;
using System.Collections.Generic;

namespace studentEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some cohorts
            Cohort cohort30 = new Cohort() {
                Name = "Cohort 30"
            };

            Cohort cohort22 = new Cohort("Cohort 22");

            Cohort cohort28 = new Cohort();
            cohort28.Name = "Cohort 28";

            // create some instructors
            Instructor Steve = new Instructor("Steve", "Brownlee", "@coach", cohort30);

            Instructor Joe = new Instructor("Joe", "Shep", "@joes", cohort28);

            Instructor Meg = new Instructor("Meg", "Ducharme", "megs", cohort22);

            Instructor Kimmy = new Instructor("Kimmy", "Bird", "kimmy", cohort30);

            // create some exercises
            Exercise OverlyExcited = new Exercise("Overly Excited", "Javascript");

            Exercise BagOLoot = new Exercise("Bag of Loot", "C#");

            Exercise Comprehensions = new Exercise("Comprehensions", "Python");

            Exercise Chinook = new Exercise("Chinook", "SQL");

            // create some students


            // have instructor(s) assign exercises to students


            // list out all of the cohorts
            List<Cohort> AllCohorts = new List<Cohort>() {
                cohort22,
                cohort22,
                cohort30
            };

            AllCohorts.ForEach(c => Console.WriteLine($"{c.Name}"));

            // list out all of the exercises
            List<Exercise> AllExercises = new List<Exercise>() {
                OverlyExcited,
                BagOLoot,
                Comprehensions,
                Chinook
            };

            AllExercises.ForEach(ex => Console.WriteLine($"{ex.Name}: {ex.Language}"));

            // list out all of the instructors
            List<Instructor> AllInstructors = new List<Instructor>() {
                Steve,
                Joe,
                Meg,
                Kimmy
            };

            AllInstructors.ForEach(i => Console.WriteLine($"{i.FirstName} {i.LastName} is the instructor for {i.Cohort.Name}"));
        }
    }
}
