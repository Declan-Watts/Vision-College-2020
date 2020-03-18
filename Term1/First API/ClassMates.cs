using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_API
{
    public class ClassMates
    {
        public string Level { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Role { get; }

        public ClassMates(string level, string name, int age)
        {
            Level = level;
            Name = name;
            Age = age;
            Role = setRole();
        }

        private string setRole()
        {
            string role;
            if (Name == "Declan")
            {
                role = "Admin";
            }
            else
            {
                role = "User";
            }
            return role;
        }
    }
}
