using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstApproach.Models
{
    [Table("emp")]
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Key]
        public int Eno { get; set; }
        public string Ename { get; set; }
        public double Esalary { get; set; }
        public string Designation { get; set; }
    }
}