namespace HDaycareManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateKidsParentsAndAttendace : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModifiedDateTime = c.DateTime(nullable: false),
                        Kid_Id = c.Int(),
                        Parent_Id = c.Int(),
                        Status_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kids", t => t.Kid_Id)
                .ForeignKey("dbo.Parents", t => t.Parent_Id)
                .ForeignKey("dbo.Status", t => t.Status_Id)
                .Index(t => t.Kid_Id)
                .Index(t => t.Parent_Id)
                .Index(t => t.Status_Id);
            
            CreateTable(
                "dbo.Kids",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.Int(nullable: false),
                        LastName = c.Int(nullable: false),
                        Years = c.Int(nullable: false),
                        Months = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Parents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StatusName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ParentKids",
                c => new
                    {
                        Parent_Id = c.Int(nullable: false),
                        Kid_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Parent_Id, t.Kid_Id })
                .ForeignKey("dbo.Parents", t => t.Parent_Id, cascadeDelete: true)
                .ForeignKey("dbo.Kids", t => t.Kid_Id, cascadeDelete: true)
                .Index(t => t.Parent_Id)
                .Index(t => t.Kid_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.Attendances", "Parent_Id", "dbo.Parents");
            DropForeignKey("dbo.Attendances", "Kid_Id", "dbo.Kids");
            DropForeignKey("dbo.ParentKids", "Kid_Id", "dbo.Kids");
            DropForeignKey("dbo.ParentKids", "Parent_Id", "dbo.Parents");
            DropIndex("dbo.ParentKids", new[] { "Kid_Id" });
            DropIndex("dbo.ParentKids", new[] { "Parent_Id" });
            DropIndex("dbo.Attendances", new[] { "Status_Id" });
            DropIndex("dbo.Attendances", new[] { "Parent_Id" });
            DropIndex("dbo.Attendances", new[] { "Kid_Id" });
            DropTable("dbo.ParentKids");
            DropTable("dbo.Status");
            DropTable("dbo.Parents");
            DropTable("dbo.Kids");
            DropTable("dbo.Attendances");
        }
    }
}
