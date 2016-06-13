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
        
        //created instructor inside course
        //TODO: Create instructor outside if needed
        public string InstructorName { get; set; }
        
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
