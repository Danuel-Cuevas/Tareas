using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1csharp.Entities
{
    internal class Ex_student : Comunity_Member
    {
        public int Graduation_time { get; set; }
        public Ex_student(string name, string email, string phoneNumber, DateTime dateOfBirth, int graduation_time)
            : base(name, email, phoneNumber, dateOfBirth)
        {
            Graduation_time = graduation_time;
        }
        public override string Got_information()
        {
            return base.Got_information() + $"\nGraduation Time: {Graduation_time} years ago";
        }
    }
}
