namespace POCAcademicSystem.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourseInstructor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Course", "InstructorName", c => c.String(nullable: false, maxLength: 200, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Course", "InstructorName");
        }
    }
}
