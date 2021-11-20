using System;
using System.Collections.Generic;
using System.Text;

namespace Lap5_DB4O
{
    public class Department
    {
        public int DNumber { get; set; }
        public string DName { get; set; }
        public string MgrStartDate { get; set; }
        // relationships
        public List<Employee> Employees { get; set; }
        public Employee Manager { get; set; }
        public List<Project> Projects { get; set; }

        // attributes
     
        public string Locations { get; set; }
        // relationships

    }
}
