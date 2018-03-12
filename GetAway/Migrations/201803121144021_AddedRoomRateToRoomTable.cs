namespace GetAway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRoomRateToRoomTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "RoomRate", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rooms", "RoomRate");
        }
    }
}
