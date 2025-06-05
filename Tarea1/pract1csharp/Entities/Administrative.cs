using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1csharp.Entities
{
    internal class Administrative: Employee
    {
        public string Role { get; set; }
        public Administrative(string name, string email, string phoneNumber, DateTime dateOfBirth, string department, string role)
            : base(name, email, phoneNumber, dateOfBirth, department)
        {
            Role = role;
        }
        public override string Got_information()
        {
            return base.Got_information() + $"\nRole: {Role}";
        }
    }
}
