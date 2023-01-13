using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance.Classes.HR
{
    public class Employee : Person
    {
        private DateTime _startDate;

        public DateTime StartDate
        {
            get { return _startDate; }
            private set { _startDate = value.Date; }
        }
        public Employee(string name, DateTime dateOfBirth, DateTime startDate) : base(name, dateOfBirth)
        {
            StartDate = startDate;
        }

        public int YearsOfService()
        {
            TimeSpan difference = DateTime.Today - StartDate;
            int years = difference.Days / 365;
            return years;
        }

        public override string Description()
        {
            return base.Description() + $" YearsOfService: {YearsOfService()}";
        }
    }
}
