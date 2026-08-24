namespace Savemor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Parent = c.Int(nullable: false),
                        Headline = c.String(),
                        Image = c.String(),
                        Saving = c.Int(nullable: false),
                        SortOrder = c.Int(nullable: false),
                        CustomString1 = c.String(),
                        CustomString2 = c.String(),
                        CustomString3 = c.String(),
                        CustomString4 = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
