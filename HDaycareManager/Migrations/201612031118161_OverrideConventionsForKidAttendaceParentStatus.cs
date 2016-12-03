namespace HDaycareManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsForKidAttendaceParentStatus : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Attendances", "Kid_Id", "dbo.Kids");
            DropForeignKey("dbo.Attendances", "Parent_Id", "dbo.Parents");
            DropForeignKey("dbo.Attendances", "Status_Id", "dbo.Status");
            DropIndex("dbo.Attendances", new[] { "Kid_Id" });
            DropIndex("dbo.Attendances", new[] { "Parent_Id" });
            DropIndex("dbo.Attendances", new[] { "Status_Id" });
            AddColumn("dbo.Attendances", "ProviderId", c => c.String());
            AddColumn("dbo.Kids", "ProviderId", c => c.String(nullable: false));
            AddColumn("dbo.Parents", "Provider_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Status", "ProviderId", c => c.String(nullable: false));
            AlterColumn("dbo.Attendances", "Kid_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Attendances", "Parent_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Attendances", "Status_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Kids", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Kids", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Parents", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Parents", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Status", "StatusName", c => c.String(nullable: false));
            CreateIndex("dbo.Attendances", "Kid_Id");
            CreateIndex("dbo.Attendances", "Parent_Id");
            CreateIndex("dbo.Attendances", "Status_Id");
            CreateIndex("dbo.Parents", "Provider_Id");
            AddForeignKey("dbo.Parents", "Provider_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Attendances", "Kid_Id", "dbo.Kids", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Attendances", "Parent_Id", "dbo.Parents", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Attendances", "Status_Id", "dbo.Status", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "Status_Id", "dbo.Status");
            DropForeignKey("dbo.Attendances", "Parent_Id", "dbo.Parents");
            DropForeignKey("dbo.Attendances", "Kid_Id", "dbo.Kids");
            DropForeignKey("dbo.Parents", "Provider_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Parents", new[] { "Provider_Id" });
            DropIndex("dbo.Attendances", new[] { "Status_Id" });
            DropIndex("dbo.Attendances", new[] { "Parent_Id" });
            DropIndex("dbo.Attendances", new[] { "Kid_Id" });
            AlterColumn("dbo.Status", "StatusName", c => c.String());
            AlterColumn("dbo.Parents", "LastName", c => c.String());
            AlterColumn("dbo.Parents", "FirstName", c => c.String());
            AlterColumn("dbo.Kids", "LastName", c => c.String());
            AlterColumn("dbo.Kids", "FirstName", c => c.String());
            AlterColumn("dbo.Attendances", "Status_Id", c => c.Int());
            AlterColumn("dbo.Attendances", "Parent_Id", c => c.Int());
            AlterColumn("dbo.Attendances", "Kid_Id", c => c.Int());
            DropColumn("dbo.Status", "ProviderId");
            DropColumn("dbo.Parents", "Provider_Id");
            DropColumn("dbo.Kids", "ProviderId");
            DropColumn("dbo.Attendances", "ProviderId");
            CreateIndex("dbo.Attendances", "Status_Id");
            CreateIndex("dbo.Attendances", "Parent_Id");
            CreateIndex("dbo.Attendances", "Kid_Id");
            AddForeignKey("dbo.Attendances", "Status_Id", "dbo.Status", "Id");
            AddForeignKey("dbo.Attendances", "Parent_Id", "dbo.Parents", "Id");
            AddForeignKey("dbo.Attendances", "Kid_Id", "dbo.Kids", "Id");
        }
    }
}
