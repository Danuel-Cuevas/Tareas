using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1csharp.Entities
{
    internal class Comunity_Member
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Comunity_Member(string name, string email, string phoneNumber, DateTime dateOfBirth)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
        }
        public virtual string Got_information()
        {
            return $"Name: {Name}, Email: {Email}, Phone: {PhoneNumber}, DOB: {DateOfBirth.ToShortDateString()}";
        }
    }
}
