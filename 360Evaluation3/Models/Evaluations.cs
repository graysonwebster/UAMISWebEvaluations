namespace _360Evaluation3.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Evaluations : DbContext
    {
        // Your context has been configured to use a 'Evaluations' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // '_360Evaluation3.Models.Evaluations' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Evaluations' 
        // connection string in the application configuration file.
        public Evaluations()
            : base("name=Evaluations")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<QuestionGroup> QuestionGroup { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}