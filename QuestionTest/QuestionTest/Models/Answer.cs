using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace QuestionTest.Models
{
    public enum PhoneBrand
    {
        None,
        Apple,
        Samsung,
        LG,
        Nokia,
        Другое
    }

    public enum Sex
    {
        Male,
        Female
    }

    public class Answer
    {
        public int Id { get; set; }
        public PhoneBrand PhoneBrand { get; set; }
        public Sex Sex { get; set; }
    }

    public class AnswerContext : DbContext
    {
       
        public DbSet<Answer> Answers { get; set; }
    }
}