using System;
using System.Collections.Generic;

namespace studentEx1
{
    public class Student
    {
    
    /*
    REQUIREMENTS:
        First name
        Last name
        Slack handle
        The student's cohort
        The collection of exercises that the student is currently working on
    */


    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string SlackHandle { get; set; }

    public Cohort Cohort { get; set; }

    public List<Exercise> Exercises { get; set; } = new List<Exercise>();

    public Student(string firstName, string lastName, string slackHandle, Cohort cohort) 
    {
        FirstName = firstName;
        LastName = lastName;
        SlackHandle = slackHandle;
        Cohort = cohort;

    }

       
    public override string ToString() {
        return $@"{FirstName} {LastName}";
    }

    }
}














