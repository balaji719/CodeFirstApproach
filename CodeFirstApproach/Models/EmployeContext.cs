using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeFirstApproach.Models
{
    public class EmployeContext : DbContext
    {
        public EmployeContext():base("con")
        {

        }
        public DbSet<Models.Employee> Employees { get; set; }
    }
}