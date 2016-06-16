using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Domain.Model;
using POCAcademicSystem.Model;

namespace POCAcademicSystem.Core.Translators
{
    public static class EnrollmentTranslator
    {
        public static EnrollmentDomain ToDomain(this Enrollment enrollmentModel)
        {
            return new EnrollmentDomain
            {
                EnrollmentId = enrollmentModel.EnrollmentId,
                CourseId = enrollmentModel.CourseId,
                Grade = enrollmentModel.Grade,
                StudentId = enrollmentModel.StudentId,
                Course = enrollmentModel.Course.ToDomain(),
                Student = enrollmentModel.Student.ToDomain()
            };
        }

        public static Enrollment ToPersistence(this EnrollmentDomain enrollmentDomain)
        {
            return new Enrollment
            {
                EnrollmentId = enrollmentDomain.EnrollmentId,
                CourseId = enrollmentDomain.CourseId,
                Grade = enrollmentDomain.Grade,
                StudentId = enrollmentDomain.StudentId,
                Course = enrollmentDomain.Course.ToPersistence(),
                Student = enrollmentDomain.Student.ToPersistence()
            };
        }
    }
}
