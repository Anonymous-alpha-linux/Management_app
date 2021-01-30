namespace Management_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createcourseandcate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseandCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(nullable: false),
                        CourseName = c.String(),
                        CategoryId = c.Int(nullable: false),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CourseandCategories");
        }
    }
}
