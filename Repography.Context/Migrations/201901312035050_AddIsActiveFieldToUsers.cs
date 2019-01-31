namespace Repography.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsActiveFieldToUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.USERS", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.USERS", "IsActive");
        }
    }
}
