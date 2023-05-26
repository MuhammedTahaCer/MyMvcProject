namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dateContact : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "DateContact", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "DateContact");
        }
    }
}
