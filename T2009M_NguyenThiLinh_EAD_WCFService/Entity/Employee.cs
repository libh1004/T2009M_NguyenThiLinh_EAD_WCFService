using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T2009M_NguyenThiLinh_EAD_WCFService.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
}