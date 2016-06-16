using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Domain.Model;
using POCAcademicSystem.Model;

namespace POCAcademicSystem.Core.Translators
{
    public static class StudentTranslator
    {
        public static StudentDomain ToDomain(this Student studentModel)
        {
            return new StudentDomain
            {
                StudentId = studentModel.StudentId,
                FirstName = studentModel.FirstName,
                LastName = studentModel.LastName,
                Email = studentModel.Email,
                ContactNumber = studentModel.ContactNumber,
                EnrollmentDate = studentModel.EnrollmentDate,
                Enrollments = studentModel.Enrollments != null ? studentModel.Enrollments.Select(e => e.ToDomain()).ToList()
                                                                : null
            };
        }

        public static Student ToPersistence(this StudentDomain studentDomain)
        {
            return new Student
            {
                StudentId = studentDomain.StudentId,
                FirstName = studentDomain.FirstName,
                LastName = studentDomain.LastName,
                Email = studentDomain.Email,
                ContactNumber = studentDomain.ContactNumber,
                EnrollmentDate = studentDomain.EnrollmentDate,
                Enrollments = studentDomain.Enrollments != null ? studentDomain.Enrollments.Select(e => e.ToPersistence()).ToList()
                                                                : null
            };
        }
    }
}
