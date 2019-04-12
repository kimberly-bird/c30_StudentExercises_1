using System;
using System.Collections.Generic;

namespace studentEx1
{
    public class Exercise
    {
        public string Name { get; set; }
        public string Language { get; set; }


        // constructor
        public Exercise (string name, string language)
        {
            Name = name;
            Language = language;
        }

        // parameterless constructor
        public Exercise()
        {

        }
    }
}