namespace GetAway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRoomNumberToRoomTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rooms", "RoomNumber", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rooms", "RoomNumber");
        }
    }
}
