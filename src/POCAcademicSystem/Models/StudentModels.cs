using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POCAcademicSystem.Models
{
    public class StudentModels
    {
        public StudentModels()
        {
            Enrollments = new List<EnrollmentModels>();
        }

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public DateTime? EnrollmentDate { get; set; }

        public List<EnrollmentModels> Enrollments { get; set; }
    }
}