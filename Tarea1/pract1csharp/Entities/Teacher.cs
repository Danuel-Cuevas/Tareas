using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1csharp.Entities
{
    internal class Teacher : Professor
    {
        public string Subject { get; set; }
        public Teacher(string name, string email, string phoneNumber, DateTime dateOfBirth, string department, string specialty, string subject)
            : base(name, email, phoneNumber, dateOfBirth, department, specialty)
        {
            Subject = subject;
        }
        public override string Got_information()
        {
            return base.Got_information() + $"\nSubject: {Subject}";
        }
    }
}
