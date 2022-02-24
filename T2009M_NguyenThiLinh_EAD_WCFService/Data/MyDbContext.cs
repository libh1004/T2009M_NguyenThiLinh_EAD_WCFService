using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using T2009M_NguyenThiLinh_EAD_WCFService.Entity;

namespace T2009M_NguyenThiLinh_EAD_WCFService.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("ConnectionString")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}