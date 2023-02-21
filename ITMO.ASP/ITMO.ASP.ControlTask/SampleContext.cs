using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ITMO.ASP2023.FinalTask
{
    public class SampleContext : DbContext
    {
        public SampleContext() : base("StudentsDB") { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Score> Scores { get; set; }
    }
}