using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Model;

namespace POCAcademicSystem.EntityFramework.Mappings
{
    public class CourseMapping : EntityTypeConfiguration<Course>
    {
        public CourseMapping()
        {
            ToTable("Course", "dbo");
            HasKey(c => c.CourseId);

            Property(c => c.Credits)
                .IsRequired();

            Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            Property(c => c.InstructorName)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);
            
        }
    }
}
