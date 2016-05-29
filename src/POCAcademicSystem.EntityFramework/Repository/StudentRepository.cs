using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Persistence.Repository;

namespace POCAcademicSystem.EntityFramework.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public void Add(Model.Student entity, bool isNew)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Model.Student> AsQueryable()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Model.Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Model.Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
