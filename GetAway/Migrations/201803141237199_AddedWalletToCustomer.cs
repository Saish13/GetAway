namespace GetAway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedWalletToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "WalletAmount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "WalletAmount");
        }
    }
}
