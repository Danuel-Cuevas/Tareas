using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1csharp.Entities
{
    internal class Administrator: Professor
    {
        public string AdministrationRole { get; set; }
        public Administrator(string name, string email, string phoneNumber, DateTime dateOfBirth, string department, string specialty, string administrationRole)
            : base(name, email, phoneNumber, dateOfBirth, department, specialty)
        {
            AdministrationRole = administrationRole;
        }
        public override string Got_information()
        {
            return base.Got_information() + $"\nAdministration Role: {AdministrationRole}";
        }
    }
}
