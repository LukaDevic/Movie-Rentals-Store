namespace MovieRentalsStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingNameInMemberShipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name='Pay as you Go' WHERE id=1;");
            Sql("UPDATE MembershipTypes SET Name='Monthly' WHERE id=2;");
            Sql("UPDATE MembershipTypes SET Name='Quarterly' WHERE id=3;");
            Sql("UPDATE MembershipTypes SET Name='Annual' WHERE id=4;");
        }
        
        public override void Down()
        {
        }
    }
}
