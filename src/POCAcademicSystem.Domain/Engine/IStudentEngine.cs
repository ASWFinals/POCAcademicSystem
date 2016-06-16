using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Domain.Model;

namespace POCAcademicSystem.Domain.Engine
{
    public interface IStudentEngine
    {
        int Create(StudentDomain student);
        void Update(StudentDomain student);
        void Delete(int studentId);
        StudentDomain Get(int studentId);
        IEnumerable<StudentDomain> GetAll();



    }
}
