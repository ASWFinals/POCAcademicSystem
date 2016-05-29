using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Domain.Engine;
using POCAcademicSystem.Persistence;
using POCAcademicSystem.Persistence.Repository;
using Takenet.Library.Data;

namespace POCAcademicSystem.Core.Engine
{
    public class StudentEngine : IStudentEngine
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStudentRepository _studentRepository;

        public StudentEngine(IPOCAcademicContext context)
        {
            _unitOfWork = context;
            _studentRepository = context.StudentRepository;
        }

        //TODO: regras de nogocio
    }
}
