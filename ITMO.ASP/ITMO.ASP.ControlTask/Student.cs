using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ITMO.ASP2023.FinalTask
{
    public class Student
    {
        public Student() { }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Score { get; set; }

        public Student(string FirstName, string LastName, int Score)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Score = Score;
        }
    }
}