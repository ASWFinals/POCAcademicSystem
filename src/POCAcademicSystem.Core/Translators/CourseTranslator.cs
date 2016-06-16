using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Domain.Model;
using POCAcademicSystem.Model;

namespace POCAcademicSystem.Core.Translators
{
    public static class CourseTranslator
    {
        public static CourseDomain ToDomain(this Course courseModel)
        {
            return new CourseDomain
            {
                CourseId = courseModel.CourseId,
                Credits = courseModel.Credits,
                Enrollments = courseModel.Enrollments.Select(e => e.ToDomain()).ToList(),
                InstructorName = courseModel.InstructorName,
                Title = courseModel.Title
            };
        }

        public static Course ToPersistence(this CourseDomain courseDomain)
        {
            return new Course
            {
                CourseId = courseDomain.CourseId,
                Credits = courseDomain.Credits,
                Enrollments = courseDomain.Enrollments.Select(e => e.ToPersistence()).ToList(),
                InstructorName = courseDomain.InstructorName,
                Title = courseDomain.Title
            };
        }
    }
}
