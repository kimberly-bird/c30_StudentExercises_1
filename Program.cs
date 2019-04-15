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

            Cohort cohort29 = new Cohort("Cohort 29");

            Cohort cohort28 = new Cohort();
            cohort28.Name = "Cohort 28";

            // create some instructors
            // notice how I have the cohort as the variable name of a cohort, because that is the whole instance of a cohort
            Instructor Steve = new Instructor() {
                FirstName = "Steve", 
                LastName = "Brownlee", 
                SlackHandle = "@coach", 
                Cohort = cohort30
            };

            Instructor Joe = new Instructor("Joe", "Shep", "@joes", cohort28);

            Instructor Jenna = new Instructor("Jenna", "Solis", "jenna", cohort30);

            Instructor Kimmy = new Instructor("Kimmy", "Bird", "kimmy", cohort30);

            Instructor Andy = new Instructor("Andy", "Collins", "Andy", cohort29);

            // create some exercises
            Exercise OverlyExcited = new Exercise("Overly Excited", "Javascript");

            Exercise BagOLoot = new Exercise("Bag of Loot", "C#");

            Exercise Comprehensions = new Exercise("Comprehensions", "Python");

            Exercise Chinook = new Exercise("Chinook", "SQL");

            // create some students


            // have instructor(s) assign exercises to students


            // list out all of the cohorts
            List<Cohort> AllCohorts = new List<Cohort>() {
                cohort28,
                cohort29,
                cohort30
            };

            // I don't need to do dot notation for the name of the Cohort, because I have that as the default string to be returned because of the ToString() override method in my Cohort class.
            AllCohorts.ForEach(c => Console.WriteLine($"{c}"));

            // list out all of the exercises
            List<Exercise> AllExercises = new List<Exercise>() {
                OverlyExcited,
                BagOLoot,
                Comprehensions,
                Chinook
            };

            // I don't need to do dot notation for the name of the exercise, because I have that as the default string to be returned because of the ToString() override method in my Exercise class. Language, however, is not in that method override, so I do need dot notation.
            AllExercises.ForEach(ex => Console.WriteLine($"{ex}: {ex.Language}"));

            // list out all of the instructors
            List<Instructor> AllInstructors = new List<Instructor>() {
                Steve,
                Joe,
                Jenna,
                Kimmy,
                Andy
            };

            // I have a getter property on my Instructor that returns the full name of an instructor, so I don't have to worry about typing out {i.FirstName} {i.LastName}
            // notice how we can access the name of the cohort through dot notation - we can do this because we have set the whole instance of the cohort on the instructor as a foreign key.
            AllInstructors.ForEach(i => Console.WriteLine($"{i.FullName} is the instructor for {i.Cohort.Name}"));
        
            Student Nathan = new Student("Nathan", "Sev", "@nathan", cohort30);

            Console.WriteLine(Nathan.Cohort.Name);
            Console.WriteLine(Nathan);

            Kimmy.AssignExercise(Nathan, OverlyExcited);
            Kimmy.AssignExercise(Nathan, BagOLoot);

            Console.WriteLine($"Nathan has {Nathan.Exercises.Count} exercises");

            Nathan.Exercises.ForEach(ex => Console.WriteLine($"{ex.Name} {ex.Language}"));

            foreach (var ex in Nathan.Exercises)
            {
                Console.WriteLine($"Version 2: {ex.Name} in {ex.Language}");
            }


        }
    }
}












