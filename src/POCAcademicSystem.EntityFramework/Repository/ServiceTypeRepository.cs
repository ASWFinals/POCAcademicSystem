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
    public class ServiceTypeRepository : POCAcademicRepository<ServiceType, short>, IServiceTypeRepository
    {
        public ServiceTypeRepository(DbContext context)
            : base(context)
        {

        }
    }
}
