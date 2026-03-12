using System;
using System.Collections.Generic;

namespace POSLayer.Models;

public partial class Employee : BaseClass
{
    public string EmployeeName { get; set; }     
    public double Rate { get; set; }
    public bool Shortable { get; set; }

}
