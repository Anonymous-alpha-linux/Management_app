namespace Management_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newregis : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Administrators");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Administrators",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
