namespace GetAway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteringPackageTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Packages");
        }
        
        public override void Down()
        {
            
        }
    }
}
