using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace HRSystemCoreAPI.DatabaseEntity
{
    public partial class Department
    {
        public Department()
        {
            People = new HashSet<Person>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int CompanyId { get; set; }

        [JsonIgnore]
        public virtual Company Company { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}
