using System;
using System.Collections.Generic;

#nullable disable

namespace HopePharmacy.Entities
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public DateTime JoinDate { get; set; }
        public string Qualifications { get; set; }
        public string Position { get; set; }
        public bool? Shift { get; set; }
        public double? YearsOfExperience { get; set; }
    }
}
