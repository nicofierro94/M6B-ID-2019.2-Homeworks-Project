using System;
using System.Collections.Generic;

namespace Homeworks.Domain
{
    public class Homework
    {
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
        public List<Excercise> Excercises { get; set; }
        public Homework() 
        {
            Excercises = new List<Excercise>();
        }
    }
}
