using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1csharp.Entities
{
    internal class Employee : Comunity_Member
    {
        public string Department { get; set; }
        public Employee(string name, string email, string phoneNumber, DateTime dateOfBirth, string department)
            : base(name, email, phoneNumber, dateOfBirth)
        {
            Department = department;
        }
        public override string Got_information()
        {
            return base.Got_information() + $"\nDepartment: {Department}";
        }
}   }
