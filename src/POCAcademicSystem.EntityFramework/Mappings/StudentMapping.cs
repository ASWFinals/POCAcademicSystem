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
        }
    }
}
