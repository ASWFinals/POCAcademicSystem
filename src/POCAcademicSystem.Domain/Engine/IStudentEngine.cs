using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Model;

namespace POCAcademicSystem.Domain.Engine
{
    public interface IStudentEngine
    {
        int Create(Student student);
        void Update(Student student);
        void Delete(int studentId);
        Student Get(int studentId);
        IEnumerable<Student> GetAll();



    }
}
