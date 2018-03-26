namespace GetAway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteredRoomBookingUserID : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RoomBookings", "UserID", c => c.String(maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RoomBookings", "UserID", c => c.Int(nullable: false));
        }
    }
}
