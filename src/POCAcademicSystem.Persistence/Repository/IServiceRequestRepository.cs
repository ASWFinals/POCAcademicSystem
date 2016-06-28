using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Model;
using Takenet.Library.Data;

namespace POCAcademicSystem.Persistence.Repository
{
    public interface IServiceRequestRepository : IEntityRepository<ServiceRequest, int>
    {
    }
}
