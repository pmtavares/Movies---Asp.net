namespace Movies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMembershipTypesNames : DbMigration
    {
        public override void Up()
        {

            Sql("Update MembershipTypes SET TypeOfMembership = 'Pay as you go' WHERE Id = 1");
            Sql("Update MembershipTypes SET TypeOfMembership = 'Monthly' WHERE Id = 2");
            Sql("Update MembershipTypes SET TypeOfMembership = 'Quartely' WHERE Id = 3");
            Sql("Update MembershipTypes SET TypeOfMembership = 'Annually' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
