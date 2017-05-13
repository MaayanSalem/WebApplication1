namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StartRunTime = c.DateTime(nullable: false),
                        EndRunTime = c.DateTime(nullable: false),
                        Distance = c.Double(nullable: false),
                        Speed = c.Double(nullable: false),
                        StartLocation_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Locations", t => t.StartLocation_ID)
                .Index(t => t.StartLocation_ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                        FullName = c.String(),
                        StartRunTime = c.DateTime(nullable: false),
                        EndRunTime = c.DateTime(nullable: false),
                        Age = c.Int(nullable: false),
                        City = c.String(),
                        Distance = c.Double(nullable: false),
                        Speed = c.Double(nullable: false),
                        Gender = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Measurements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Duration = c.Time(nullable: false, precision: 7),
                        Date = c.DateTime(nullable: false),
                        AverageSpeed = c.Double(nullable: false),
                        Distance = c.Double(nullable: false),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Country = c.String(),
                        City = c.String(),
                        Street = c.String(),
                        Number = c.String(),
                        Destination = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserGroups",
                c => new
                    {
                        User_ID = c.Int(nullable: false),
                        Group_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_ID, t.Group_ID })
                .ForeignKey("dbo.Users", t => t.User_ID, cascadeDelete: true)
                .ForeignKey("dbo.Groups", t => t.Group_ID, cascadeDelete: true)
                .Index(t => t.User_ID)
                .Index(t => t.Group_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Groups", "StartLocation_ID", "dbo.Locations");
            DropForeignKey("dbo.Measurements", "User_ID", "dbo.Users");
            DropForeignKey("dbo.UserGroups", "Group_ID", "dbo.Groups");
            DropForeignKey("dbo.UserGroups", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Users", "User_ID", "dbo.Users");
            DropIndex("dbo.UserGroups", new[] { "Group_ID" });
            DropIndex("dbo.UserGroups", new[] { "User_ID" });
            DropIndex("dbo.Measurements", new[] { "User_ID" });
            DropIndex("dbo.Users", new[] { "User_ID" });
            DropIndex("dbo.Groups", new[] { "StartLocation_ID" });
            DropTable("dbo.UserGroups");
            DropTable("dbo.Locations");
            DropTable("dbo.Measurements");
            DropTable("dbo.Users");
            DropTable("dbo.Groups");
        }
    }
}
