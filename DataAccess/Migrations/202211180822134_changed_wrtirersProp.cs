namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changed_wrtirersProp : DbMigration
    {
        public override void Up()//güncellenen kısım(update-database komutu kullanırsam(package console management))
        {
            AddColumn("dbo.Writers", "About", c => c.String());
            AlterColumn("dbo.Writers", "Password", c => c.String(maxLength: 24));
        }
        
        public override void Down()//migration kadırmak isterm bu çalışacak
        {
            AlterColumn("dbo.Writers", "Password", c => c.Int(nullable: false));
            DropColumn("dbo.Writers", "About");
        }
    }
}
