using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Model;

namespace POCAcademicSystem.EntityFramework.Mappings
{
    public class EnrollmentMapping : EntityTypeConfiguration<Enrollment>
    {
        public EnrollmentMapping()
        {
            ToTable("Enrollment", "dbo");
            HasKey(e => e.EnrollmentId);

            Property(e => e.Grade)
                .IsOptional();

            //Course
            HasRequired<Course>(e => e.Course) //enrollment entity requires course. Cannot save enrollment without Course
                .WithMany(e => e.Enrollments); 
            

            //Student
            HasRequired<Student>(e => e.Student) //enrollment entity requires student. Cannot save enrollment without Student
                .WithMany(e => e.Enrollments); 

        }
    }
}
