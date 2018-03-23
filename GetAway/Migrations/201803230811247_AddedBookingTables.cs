namespace GetAway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBookingTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PackageBookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookingDate = c.DateTime(nullable: false),
                        PackageStartDate = c.DateTime(nullable: false),
                        PackageEndDate = c.DateTime(nullable: false),
                        BookingStatus = c.Byte(nullable: false),
                        PaymentStatus = c.Byte(nullable: false),
                        AdditionaInfo = c.String(),
                        PaidAmount = c.Int(nullable: false),
                        DiscountReceived = c.Byte(nullable: false),
                        PackageId = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.Packages", t => t.PackageId, cascadeDelete: true)
                .Index(t => t.PackageId)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.RoomBookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookingDate = c.DateTime(nullable: false),
                        RoomStartDate = c.DateTime(nullable: false),
                        RoomEndDate = c.DateTime(nullable: false),
                        BookingStatus = c.Byte(nullable: false),
                        PaymentStatus = c.Byte(nullable: false),
                        AdditionaInfo = c.String(),
                        PaidAmount = c.Int(nullable: false),
                        DiscountReceived = c.Byte(nullable: false),
                        RoomId = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoomBookings", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.RoomBookings", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.PackageBookings", "PackageId", "dbo.Packages");
            DropForeignKey("dbo.PackageBookings", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.RoomBookings", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.RoomBookings", new[] { "RoomId" });
            DropIndex("dbo.PackageBookings", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.PackageBookings", new[] { "PackageId" });
            DropTable("dbo.RoomBookings");
            DropTable("dbo.PackageBookings");
        }
    }
}
