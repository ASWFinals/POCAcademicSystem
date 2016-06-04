namespace POCAcademicSystem.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AvoidCascadeDeleteEnrollmentMapping : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Enrollment", "CourseId", "dbo.Course");
            DropForeignKey("dbo.Enrollment", "StudentId", "dbo.Student");
            AddForeignKey("dbo.Enrollment", "CourseId", "dbo.Course", "CourseId");
            AddForeignKey("dbo.Enrollment", "StudentId", "dbo.Student", "StudentId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollment", "StudentId", "dbo.Student");
            DropForeignKey("dbo.Enrollment", "CourseId", "dbo.Course");
            AddForeignKey("dbo.Enrollment", "StudentId", "dbo.Student", "StudentId", cascadeDelete: true);
            AddForeignKey("dbo.Enrollment", "CourseId", "dbo.Course", "CourseId", cascadeDelete: true);
        }
    }
}
