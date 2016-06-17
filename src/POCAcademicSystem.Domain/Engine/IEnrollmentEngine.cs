using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Domain.Model;

namespace POCAcademicSystem.Domain.Engine
{
    public interface IEnrollmentEngine
    {
        int Create(EnrollmentDomain enrollmentDomain);

        EnrollmentDomain Get(int id);

        void Update(EnrollmentDomain enrollmentDomain);

        void Delete(int id);

        IEnumerable<EnrollmentDomain> GetAll();
    }
}
