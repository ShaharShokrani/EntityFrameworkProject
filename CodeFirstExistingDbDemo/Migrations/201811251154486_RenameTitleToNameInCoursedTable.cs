namespace CodeFirstExistingDbDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTitleToNameInCoursedTable : DbMigration
    {
        public override void Up()
        {
            //RenameColumn("dbo.Courses", "Title", "Name");
            
            AddColumn("dbo.Courses", "Name", c => c.String(nullable: false));
            Sql("UPDATE dbo.Courses SET Name = Title");
            DropColumn("dbo.Courses", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Title", c => c.String());
            Sql("UPDATE dbo.Courses SET Title = Name");
            DropColumn("dbo.Courses", "Name");
        }
    }
}
