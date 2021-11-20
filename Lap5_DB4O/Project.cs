using System;
using System.Collections.Generic;
using System.Text;

namespace Lap5_DB4O
{
    public class Project
    {
        public int PNumber { get; set; }
        public string PName { get; set; }
        public string Location { get; set; }
        // relationships
        public Department ControlledBy { get; set; }
        public List<WorksOn> WorksOn { get; set; }
    }
    public class WorksOn
    {
        public WorksOn(float hours)
        {
            Hours = hours;
        }

        // attribute
        public float Hours { get; set; }
        //owner attributes
        public Employee Employee { get; set; }
        public Project Project { get; set; }
    }
}
