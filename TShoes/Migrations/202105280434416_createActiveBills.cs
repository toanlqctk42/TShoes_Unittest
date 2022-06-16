namespace TShoes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createActiveBills : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bills", "Active", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bills", "Active");
        }
    }
}
