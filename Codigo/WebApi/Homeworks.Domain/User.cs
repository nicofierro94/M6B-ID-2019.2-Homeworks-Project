using System;

namespace Homeworks.Domain
{
    public class User
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public bool IsAdmin { get; set; }
        public string Password { get; set; }
        public User() { }
    }
}
