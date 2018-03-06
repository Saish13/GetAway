namespace GetAway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUpdatedPackageTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Packages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PackageName = c.String(nullable: false, maxLength: 255),
                        PackagePicture1 = c.String(maxLength: 255),
                        PackagePicture2 = c.String(maxLength: 255),
                        PackagePicture3 = c.String(maxLength: 255),
                        PackagePicture4 = c.String(maxLength: 255),
                        PackagePicture5 = c.String(maxLength: 255),
                        PackagePicture6 = c.String(maxLength: 255),
                        PackageType = c.String(maxLength: 255),
                        PackageDescription = c.String(),
                        PackageActivities = c.String(),
                        PackageDuration = c.Byte(nullable: false),
                        Rate = c.Int(nullable: false),
                        Discount = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Packages");
        }
    }
}
