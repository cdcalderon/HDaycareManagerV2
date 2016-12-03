namespace HDaycareManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateKidsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO KIDS ( FirstName, LastName, Years, Months, ProviderId) VALUES( 'Wait', 'Patrickins', 2, 6, 1)");
            Sql("INSERT INTO KIDS ( FirstName, LastName, Years, Months, ProviderId) VALUES( 'Lorein', 'Watson', 1, 2, 1)");
            Sql("INSERT INTO KIDS ( FirstName, LastName, Years, Months, ProviderId) VALUES( 'Sofia', 'Calderon', 3, 2, 1)");
            Sql("INSERT INTO KIDS ( FirstName, LastName, Years, Months, ProviderId) VALUES( 'Emily', 'Lopez', 2, 4, 1)");

        }
        
        public override void Down()
        {
            Sql("DELETE FROM KIDS WHERE ID IN (1, 2, 3, 4)");
        }
    }
}
