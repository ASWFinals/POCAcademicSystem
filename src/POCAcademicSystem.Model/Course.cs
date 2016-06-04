using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCAcademicSystem.Model
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public byte Credits { get; set; }

        //TODO: ADD Enrollments and Department
    }
}
