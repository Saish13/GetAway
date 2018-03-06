namespace GetAway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedHotelTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HotelName = c.String(nullable: false, maxLength: 255),
                        HotelAddress = c.String(),
                        HotelContactNumber = c.String(maxLength: 255),
                        HotelPicture1 = c.String(maxLength: 255),
                        HotelPicture2 = c.String(maxLength: 255),
                        HotelPicture3 = c.String(maxLength: 255),
                        HotelPicture4 = c.String(maxLength: 255),
                        HotelPicture5 = c.String(maxLength: 255),
                        HotelPicture6 = c.String(maxLength: 255),
                        HotelRooms = c.Byte(nullable: false),
                        HotelDescription = c.String(),
                        HotelRating = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hotels");
        }
    }
}
