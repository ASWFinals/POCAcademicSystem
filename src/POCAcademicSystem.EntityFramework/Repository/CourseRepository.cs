using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Model;
using POCAcademicSystem.Persistence.Repository;

namespace POCAcademicSystem.EntityFramework.Repository
{
    public class CourseRepository : POCAcademicRepository<Course, int>, ICourseRepository
    {
        public CourseRepository(DbContext context)
            : base(context)
        {

        }
    }
}
