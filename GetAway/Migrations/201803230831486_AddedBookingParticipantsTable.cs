namespace GetAway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBookingParticipantsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PackageBookingParticipants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParticipantName = c.String(),
                        ParticipantAge = c.Int(nullable: false),
                        PackageBookingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PackageBookings", t => t.PackageBookingId, cascadeDelete: true)
                .Index(t => t.PackageBookingId);
            
            CreateTable(
                "dbo.RoomBookingParticipants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParticipantName = c.String(),
                        ParticipantAge = c.Int(nullable: false),
                        RoomBookingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RoomBookings", t => t.RoomBookingId, cascadeDelete: true)
                .Index(t => t.RoomBookingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoomBookingParticipants", "RoomBookingId", "dbo.RoomBookings");
            DropForeignKey("dbo.PackageBookingParticipants", "PackageBookingId", "dbo.PackageBookings");
            DropIndex("dbo.RoomBookingParticipants", new[] { "RoomBookingId" });
            DropIndex("dbo.PackageBookingParticipants", new[] { "PackageBookingId" });
            DropTable("dbo.RoomBookingParticipants");
            DropTable("dbo.PackageBookingParticipants");
        }
    }
}
