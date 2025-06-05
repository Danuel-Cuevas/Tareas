using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1csharp.Entities
{
    internal class Student : Comunity_Member
    {
        public string Career { get; set; }
        public Student(string name, string email, string phoneNumber, DateTime dateOfBirth, string career)
            : base(name, email, phoneNumber, dateOfBirth)
        {
            Career = career;
        }
        public override string Got_information()
        {
            return base.Got_information() + $"\nCareer: {Career}";
        }
    }
}

