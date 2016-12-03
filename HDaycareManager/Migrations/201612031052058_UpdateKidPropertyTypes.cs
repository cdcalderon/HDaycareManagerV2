namespace HDaycareManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateKidPropertyTypes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kids", "FirstName", c => c.String());
            AlterColumn("dbo.Kids", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kids", "LastName", c => c.Int(nullable: false));
            AlterColumn("dbo.Kids", "FirstName", c => c.Int(nullable: false));
        }
    }
}
