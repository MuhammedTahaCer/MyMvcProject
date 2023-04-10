using System.Data.Entity.Migrations;

    public partial class lokaldenResimCekmek : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Writers", "Surname", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Writers", "Surname", c => c.String(maxLength: 50));
        }
    }
