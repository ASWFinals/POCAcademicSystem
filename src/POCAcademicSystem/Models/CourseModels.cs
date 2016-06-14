using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POCAcademicSystem.Models
{
    public class CourseModels
    {
        public CourseModels()
        {
            Enrollments = new List<EnrollmentModels>();
        }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public byte Credits { get; set; }

        //created instructor inside course
        //TODO: Create instructor outside if needed
        public string InstructorName { get; set; }

        public List<EnrollmentModels> Enrollments { get; set; }
    }
}