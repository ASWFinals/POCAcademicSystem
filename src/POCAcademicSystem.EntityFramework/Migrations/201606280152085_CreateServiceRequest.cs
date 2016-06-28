namespace POCAcademicSystem.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateServiceRequest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServiceRequest",
                c => new
                    {
                        ServiceRequestId = c.Int(nullable: false, identity: true),
                        ServiceTypeId = c.Short(nullable: false),
                        RequestDateTime = c.DateTime(),
                        ResponseDateTime = c.DateTime(),
                        ServiceType_ServiceTypeId = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.ServiceRequestId)
                .ForeignKey("dbo.ServiceType", t => t.ServiceType_ServiceTypeId)
                .Index(t => t.ServiceType_ServiceTypeId);
            
            CreateTable(
                "dbo.ServiceType",
                c => new
                    {
                        ServiceTypeId = c.Short(nullable: false, identity: true),
                        Description = c.String(maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.ServiceTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceRequest", "ServiceType_ServiceTypeId", "dbo.ServiceType");
            DropIndex("dbo.ServiceRequest", new[] { "ServiceType_ServiceTypeId" });
            DropTable("dbo.ServiceType");
            DropTable("dbo.ServiceRequest");
        }
    }
}
