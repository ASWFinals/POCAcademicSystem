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
    public class StudentRepository : POCAcademicRepository<Student, int>, IStudentRepository
    {
        public StudentRepository(DbContext context)
            : base(context)
        {

        }
    }
}
