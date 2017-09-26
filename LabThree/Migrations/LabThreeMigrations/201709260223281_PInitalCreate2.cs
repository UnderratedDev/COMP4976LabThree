namespace LabThree.Migrations.LabThreeMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PInitalCreate2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        Population = c.Int(nullable: false),
                        ProvinceCode = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.Provinces", t => t.ProvinceCode)
                .Index(t => t.ProvinceCode);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ProvinceCode = c.String(nullable: false, maxLength: 128),
                        ProvinceName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ProvinceCode);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "ProvinceCode", "dbo.Provinces");
            DropIndex("dbo.Cities", new[] { "ProvinceCode" });
            DropTable("dbo.Provinces");
            DropTable("dbo.Cities");
        }
    }
}
