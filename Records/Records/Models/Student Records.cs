using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Configuration;
using System.Data.Entity;

namespace Records.Models
{
    public class Student_Records
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
      
    }
    public class RecordsDB : DbContext
    {
        public DbSet<Student_Records>Records { get; set; }
    }
}