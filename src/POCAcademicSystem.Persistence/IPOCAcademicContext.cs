using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Persistence.Repository;
using Takenet.Library.Data;

namespace POCAcademicSystem.Persistence
{
    public interface IPOCAcademicContext : IUnitOfWork
    {
        IStudentRepository StudentRepository { get; }
        ICourseRepository CourseRepository { get; }
        IEnrollmentRepository EnrollmentRepository { get; }
        IServiceTypeRepository ServiceTypeRepository { get; }
        IServiceRequestRepository ServiceRequestRepository { get; }
    }
}
