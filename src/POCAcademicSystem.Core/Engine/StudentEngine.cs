using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Domain.Engine;
using POCAcademicSystem.Persistence;
using POCAcademicSystem.Persistence.Repository;
using POCAcademicSystem.Domain.Model;
using POCAcademicSystem.Core.Translators;
using Takenet.Library.Data;
using Omu.ValueInjecter;

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
                

        public int Create(StudentDomain student)
        {
            if (student == null)
            {
                throw new InvalidOperationException("Student entity is null");
            }

            var studentModel = student.ToPersistence();

            _studentRepository.Add(studentModel, true);
            _unitOfWork.Save();

            return student.StudentId;
        }

        public void Update(StudentDomain student)
        {
            if (student == null)
            {
                throw new InvalidOperationException("Student entity is null");
            }

            if (student.StudentId != 0)
            {
                
                var studentModel = _studentRepository.GetById(student.StudentId);
                studentModel.InjectFrom(student);

                _studentRepository.Add(studentModel, false);
                _unitOfWork.Save();
            }
        }

        public void Delete(int studentId)
        {
            var student = _studentRepository.GetById(studentId);
            if (student == null)
            {
                throw new InvalidOperationException("Student entity does not exists");
            }

            _studentRepository.Remove(student);
            _unitOfWork.Save();
        }

        public StudentDomain Get(int studentId)
        {
            var studentModel = _studentRepository.GetById(studentId);

            if (studentModel != null)
            {
                return studentModel.ToDomain();
            }

            throw new InvalidOperationException("Student entity does not exists");
        }

        public IEnumerable<StudentDomain> GetAll()
        {
            var students = _studentRepository.AsQueryable();
            if (students.Any())
            {
                return students.ToList().Select(s => s.ToDomain());
            }

            throw new InvalidOperationException("There is no student");
        }
    }
}
