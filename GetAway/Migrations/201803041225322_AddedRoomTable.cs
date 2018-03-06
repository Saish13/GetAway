namespace GetAway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRoomTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomType = c.String(maxLength: 30),
                        RoomPicture1 = c.String(maxLength: 255),
                        RoomPicture2 = c.String(maxLength: 255),
                        RoomPicture3 = c.String(maxLength: 255),
                        RoomDescription = c.String(),
                        RoomStatus = c.Byte(nullable: false),
                        HotelID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hotels", t => t.HotelID, cascadeDelete: true)
                .Index(t => t.HotelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "HotelID", "dbo.Hotels");
            DropIndex("dbo.Rooms", new[] { "HotelID" });
            DropTable("dbo.Rooms");
        }
    }
}
