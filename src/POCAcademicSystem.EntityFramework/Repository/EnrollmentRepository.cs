using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Persistence.Repository;

namespace POCAcademicSystem.EntityFramework.Repository
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        public void Add(Model.Enrollment entity, bool isNew)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Model.Enrollment> AsQueryable()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Enrollment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Model.Enrollment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Model.Enrollment entity)
        {
            throw new NotImplementedException();
        }
    }
}
