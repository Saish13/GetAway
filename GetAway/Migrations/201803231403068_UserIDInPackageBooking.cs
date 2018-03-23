namespace GetAway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserIDInPackageBooking : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PackageBookings", "UserID", c => c.String(maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PackageBookings", "UserID", c => c.Int(nullable: false));
        }
    }
}
