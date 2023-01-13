using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance.Classes.HR
{
    public class Person
    {      
        private DateTime _dateOfBirth;

        public string Name { get; protected set; }

        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            private set
            {
                _dateOfBirth = value.Date;
            }
        }

        public Person(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public virtual string Description()
        {
            return $"Name:{Name} DateOfBirth:{DateOfBirth.ToString("dd/MM/yyyy")}";
        }
    }
}
