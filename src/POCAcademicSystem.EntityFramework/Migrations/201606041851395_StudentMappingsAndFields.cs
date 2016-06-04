namespace POCAcademicSystem.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentMappingsAndFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "FirstName", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AddColumn("dbo.Student", "LastName", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AddColumn("dbo.Student", "Email", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AddColumn("dbo.Student", "ContactNumber", c => c.String(maxLength: 20, unicode: false));
            AddColumn("dbo.Student", "EnrollmentDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "EnrollmentDate");
            DropColumn("dbo.Student", "ContactNumber");
            DropColumn("dbo.Student", "Email");
            DropColumn("dbo.Student", "LastName");
            DropColumn("dbo.Student", "FirstName");
        }
    }
}
