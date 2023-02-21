using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ITMO.ASP2023.FinalTask
{
    public class Score
    {
        public Score() { }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ScoreId { get; set; }
        public int ScoreValue { get; set; }
        public string ScoreDescription { get; set; }

        public Score(int ScoreValue)
        {
            this.ScoreValue = ScoreValue;
            switch (ScoreValue) 
            {
                case 0:
                    this.ScoreDescription = "Unacceptable";
                    break;
                case 1:
                    this.ScoreDescription = "Poor";
                    break;
                case 2:
                    this.ScoreDescription = "Weak";
                    break;
                case 3:
                    this.ScoreDescription = "Good";
                    break;
                case 4:
                    this.ScoreDescription = "Very Good";
                    break;
                case 5:
                    this.ScoreDescription = "Excellent";
                    break;
            }
        }
    }
}