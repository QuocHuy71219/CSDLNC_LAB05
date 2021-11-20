using System;
using System.Collections.Generic;
using System.Text;

namespace Lap5_DB4O
{
    public class Workson
    {
        // attribute public
         float Hours { get; set; }
    //owner attributes
    public Employee Employee { get; set; }
    public Project Project { get; set; }
    }
}
