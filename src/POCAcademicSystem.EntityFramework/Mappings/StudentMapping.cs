using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using POCAcademicSystem.Model;

namespace POCAcademicSystem.EntityFramework.Mappings
{
    public class StudentMapping : EntityTypeConfiguration<Student>
    {
        public StudentMapping()
        {
            ToTable("Student");
            HasKey(s => s.StudentId);

            Property(s => s.FirstName)
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode(false);

            Property(s => s.LastName)
                .HasMaxLength(50)
                .IsRequired();
                .IsUnicode(false); //avoid NVARCHAR(MAX)

            Property(s => s.Email)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsRequired();

            Property(s => s.EnrollmentDate)
                .IsRequired();
        }
    }
}
