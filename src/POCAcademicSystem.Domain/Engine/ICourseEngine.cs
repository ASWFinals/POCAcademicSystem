using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Domain.Model;

namespace POCAcademicSystem.Domain.Engine
{
    public interface ICourseEngine
    {
        int Create(CourseDomain course);

        void Update(CourseDomain course);

        void Delete(int id);

        CourseDomain Get(int id);

        IEnumerable<CourseDomain> GetAll();
    }
}
