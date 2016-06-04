using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Persistence.Repository;

namespace POCAcademicSystem.EntityFramework.Repository
{
    public class CourseRepository : ICourseRepository
    {
        public void Add(Model.Course entity, bool isNew)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Model.Course> AsQueryable()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Course> GetAll()
        {
            throw new NotImplementedException();
        }

        public Model.Course GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Model.Course entity)
        {
            throw new NotImplementedException();
        }
    }
}
