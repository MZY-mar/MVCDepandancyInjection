using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.Model
{
    public class EmployeeListRequst
    {
          public List<Employees>? Employees { get; set; }
    }
}