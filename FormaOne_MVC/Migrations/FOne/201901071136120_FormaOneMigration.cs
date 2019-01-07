namespace FormaOne_MVC.Migrations.FOne
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FormaOneMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FormaOneTeams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        Founded = c.DateTime(nullable: false),
                        WinCup = c.Int(nullable: false),
                        Payed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FormaOneTeams");
        }
    }
}
