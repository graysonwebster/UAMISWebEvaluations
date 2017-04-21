namespace _360Evaluation3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Response = c.String(),
                        Value = c.Int(),
                        RaterId = c.Int(nullable: false),
                        RateeId = c.Int(),
                        QuestionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.QuestionId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.RateeId)
                .ForeignKey("dbo.Users", t => t.RaterId, cascadeDelete: true)
                .Index(t => t.RaterId)
                .Index(t => t.RateeId)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        IsRatingQuestion = c.Boolean(nullable: false),
                        QuestionGroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.QuestionGroups", t => t.QuestionGroupId, cascadeDelete: true)
                .Index(t => t.QuestionGroupId);
            
            CreateTable(
                "dbo.QuestionGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CommentPromptText = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        IsProjectManager = c.Boolean(nullable: false),
                        IsFacultySponsor = c.Boolean(nullable: false),
                        TeamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ClientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Answers", "RaterId", "dbo.Users");
            DropForeignKey("dbo.Answers", "RateeId", "dbo.Users");
            DropForeignKey("dbo.Users", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Teams", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Questions");
            DropForeignKey("dbo.Questions", "QuestionGroupId", "dbo.QuestionGroups");
            DropIndex("dbo.Teams", new[] { "ClientId" });
            DropIndex("dbo.Users", new[] { "TeamId" });
            DropIndex("dbo.Questions", new[] { "QuestionGroupId" });
            DropIndex("dbo.Answers", new[] { "QuestionId" });
            DropIndex("dbo.Answers", new[] { "RateeId" });
            DropIndex("dbo.Answers", new[] { "RaterId" });
            DropTable("dbo.Clients");
            DropTable("dbo.Teams");
            DropTable("dbo.Users");
            DropTable("dbo.QuestionGroups");
            DropTable("dbo.Questions");
            DropTable("dbo.Answers");
        }
    }
}
