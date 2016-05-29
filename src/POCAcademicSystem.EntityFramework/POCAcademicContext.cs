using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Persistence;
using POCAcademicSystem.Model;
using Takenet.Library.Data.EntityFramework;
using System.Data.Entity;
using POCAcademicSystem.Persistence.Repository;

namespace POCAcademicSystem.EntityFramework
{
    public class POCAcademicContext : UnitOfWorkDbContext, IPOCAcademicContext
    {
        private readonly IServiceProvider _serviceProvider;

        public IDbSet<Student> Students { get; set; }

        public POCAcademicContext()
            : base("POCAcademicSystemContext")
        {

        }

        public POCAcademicContext(IServiceProvider serviceProvider)
            : base("POCAcademicSystemContext")
        {
            _serviceProvider = serviceProvider;
            Configuration.ValidateOnSaveEnabled = false;
        }

        public IStudentRepository StudentRepository
        {
            get
            {
                return _serviceProvider.GetService(typeof(IStudentRepository)) as IStudentRepository;
            }
        }
    }
}
