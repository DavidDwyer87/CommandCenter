namespace TabberService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MultiTabber_Err",
                c => new
                    {
                        Index = c.Int(nullable: false, identity: true),
                        err = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.Index);
            
           
        }
        
        public override void Down()
        {
            DropTable("dbo.MultiTabberModels");
            DropTable("dbo.MultiTabber_Err");
        }
    }
}
