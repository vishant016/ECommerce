namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class e : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Admins",
            //    c => new
            //        {
            //            Username = c.String(nullable: false, maxLength: 128),
            //            Password = c.String(),
            //        })
            //    .PrimaryKey(t => t.Username);
            
            //CreateTable(
            //    "dbo.Books",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 450),
            //            Price = c.Double(nullable: false),
            //            Author = c.String(nullable: false),
            //            Type = c.String(nullable: false),
            //            ImagePath = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .Index(t => t.Name, unique: true);
            
            //CreateTable(
            //    "dbo.Clothes",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Name = c.String(nullable: false, maxLength: 450),
            //            Type = c.String(nullable: false),
            //            Price = c.Double(nullable: false),
            //            ImagePath = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .Index(t => t.Name, unique: true);
            
            //CreateTable(
            //    "dbo.Transactions",
            //    c => new
            //        {
            //            TransactionId = c.Int(nullable: false, identity: true),
            //            BookId = c.String(),
            //            BookQuantity = c.String(),
            //            ClothId = c.String(),
            //            ClothQuantity = c.String(),
            //            TotalPrice = c.Double(nullable: false),
            //            UserId = c.Int(nullable: false),
            //            DateTime = c.DateTime(nullable: false),
            //        })
            //    .PrimaryKey(t => t.TransactionId);
            
            //CreateTable(
            //    "dbo.Users",
            //    c => new
            //        {
            //            UserId = c.Int(nullable: false, identity: true),
            //            Username = c.String(nullable: false, maxLength: 450),
            //            Email = c.String(nullable: false, maxLength: 450),
            //            Password = c.String(nullable: false),
            //            DateOfBirth = c.DateTime(nullable: false),
            //            TotalSpent = c.Double(nullable: false),
            //        })
            //    .PrimaryKey(t => t.UserId)
            //    .Index(t => t.Username, unique: true)
            //    .Index(t => t.Email, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.Clothes", new[] { "Name" });
            DropIndex("dbo.Books", new[] { "Name" });
            DropTable("dbo.Users");
            DropTable("dbo.Transactions");
            DropTable("dbo.Clothes");
            DropTable("dbo.Books");
            DropTable("dbo.Admins");
        }
    }
}
