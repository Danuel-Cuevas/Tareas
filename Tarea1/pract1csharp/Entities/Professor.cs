using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1csharp.Entities
{
    internal class Professor: Employee
    {
        public string Specialty { get; set; }
        public Professor(string name, string email, string phoneNumber, DateTime dateOfBirth, string department, string specialty)
            : base(name, email, phoneNumber, dateOfBirth, department)
        {
            Specialty = specialty;
        }
        public override string Got_information()
        {
            return base.Got_information() + $"\nSpecialty: {Specialty}";
        }
    }
}
