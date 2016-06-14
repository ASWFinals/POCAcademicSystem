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
    public class EnrollmentRepository : POCAcademicRepository<Enrollment, int>, IEnrollmentRepository
    {
        public EnrollmentRepository(DbContext context)
            : base(context)
        {

        }
    }
}
