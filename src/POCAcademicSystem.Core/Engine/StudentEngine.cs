using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Domain.Engine;
using POCAcademicSystem.Persistence;
using POCAcademicSystem.Persistence.Repository;
using POCAcademicSystem.Model;
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

        public int Create(Student student)
        {
            if (student == null)
            {
                throw new InvalidOperationException("Student entity is null");
            }

            _studentRepository.Add(student, true);
            _unitOfWork.Save();

            return student.StudentId;
        }

        public void Update(Student student)
        {
            if (student == null)
            {
                throw new InvalidOperationException("Student entity is null");
            }

            if (student.StudentId != 0)
            {
                //TODO: update model
                //var studentModel = _studentRepository.GetById(student.StudentId);
                //studentModel.ContactNumber = student.ContactNumber;
            }
        }

        public void Delete(int studentId)
        {
            throw new NotImplementedException();
        }

        public Student Get(int studentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
