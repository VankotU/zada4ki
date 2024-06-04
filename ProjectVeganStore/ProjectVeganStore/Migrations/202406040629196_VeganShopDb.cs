namespace ProjectVeganStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VeganShopDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vegans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        Vegan_type_Id = c.Int(nullable: false),
                        Type_Name = c.String(),
                        Types_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.VeganTypes", t => t.Types_Id)
                .Index(t => t.Types_Id);
            
            CreateTable(
                "dbo.VeganTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vegans", "Types_Id", "dbo.VeganTypes");
            DropIndex("dbo.Vegans", new[] { "Types_Id" });
            DropTable("dbo.VeganTypes");
            DropTable("dbo.Vegans");
        }
    }
}
