namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cs : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Books");
            DropPrimaryKey("dbo.Clothes");
            AlterColumn("dbo.Books", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Clothes", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Books", "Id");
            AddPrimaryKey("dbo.Clothes", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Clothes");
            DropPrimaryKey("dbo.Books");
            AlterColumn("dbo.Clothes", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Books", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Clothes", "Id");
            AddPrimaryKey("dbo.Books", "Id");
        }
    }
}
