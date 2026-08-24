namespace Savemor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Product : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UPI = c.Int(nullable: false),
                        PrivateLabelUPI = c.Int(nullable: false),
                        Name = c.String(),
                        Supplier = c.Int(nullable: false),
                        Image = c.String(),
                        Thumbnail = c.String(),
                        Measure = c.Int(nullable: false),
                        Units = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OppositionPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RecommendedPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SpecialPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Active = c.Boolean(nullable: false),
                        SUSMP = c.Int(nullable: false),
                        Rank = c.Int(nullable: false),
                        Limit = c.Int(nullable: false),
                        InStoreOnly = c.Boolean(nullable: false),
                        Description = c.String(),
                        KnownValueItem = c.Boolean(nullable: false),
                        CustomString1 = c.String(),
                        CustomString2 = c.String(),
                        CustomString3 = c.String(),
                        CustomString4 = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Categories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
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
            
            DropTable("dbo.Products");
        }
    }
}
