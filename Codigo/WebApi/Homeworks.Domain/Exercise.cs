using System;

namespace Homeworks.Domain
{
    public class Excercise
    {
        public Guid Id { get; set; }
        public string Problem { get; set; }
        public int Score { get; set; }
        public Excercise() { }
    }
}
