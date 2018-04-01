namespace WebReported.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        RequestParameter = c.String(),
                        ProcedureName = c.String(),
                        ReportParameter = c.String(),
                        Path = c.String(),
                        CreateBy = c.String(),
                        UpdateBy = c.String(),
                        CreateDte = c.DateTime(nullable: false),
                        UpdateDte = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reports");
        }
    }
}
