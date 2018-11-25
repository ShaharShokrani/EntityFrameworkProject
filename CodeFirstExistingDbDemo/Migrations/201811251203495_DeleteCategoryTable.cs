namespace CodeFirstExistingDbDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCategoryTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo._Categories",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);
            DropTable("dbo.Categories");

            Sql("INSERT INTO _Categories (Name) SELECT Name FROM Categories");
        }
        
        public override void Down()
        {
            Sql("INSERT INTO Categories (Name) SELECT Name FROM _Categories");

            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            DropTable("dbo._Categories");
        }
    }
}
