using System;
using System.Collections.Generic;

#nullable disable

namespace HRSystemCoreAPI.DatabaseEntity
{
    public partial class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int StatusId { get; set; }
        public int? DepartmentId { get; set; }
        public int? CompanyId { get; set; }
        public string EmployeeNumber { get; set; }
        public string Email { get; set; }

        public virtual Company Company { get; set; }
        public virtual Department Department { get; set; }
        public virtual Status Status { get; set; }
    }
}
