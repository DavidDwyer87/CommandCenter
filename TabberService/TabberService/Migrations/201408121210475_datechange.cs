namespace TabberService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datechange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MultiTabber_Err", "date", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MultiTabber_Err", "date");
        }
    }
}
