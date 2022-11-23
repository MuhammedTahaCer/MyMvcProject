namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WriterTitleIsAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "Title", c => c.String(maxLength: 24));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "Title");
        }
    }
}
