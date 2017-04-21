namespace _360Evaluation3.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Evaluations : DbContext
    {
        public Evaluations()
            : base("name=Evaluations")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<QuestionGroup> QuestionGroup { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
    }
}