using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using POCAcademicSystem.Domain.Engine;
using POCAcademicSystem.Models;
using Omu.ValueInjecter;

namespace POCAcademicSystem.Controllers
{
    public class StudentController : ApiController
    {
        private readonly IStudentEngine _studentEngine;

        public StudentController(IStudentEngine studentEngine)
        {
            _studentEngine = studentEngine;
        }

        // GET: api/Student
        public List<StudentModels> Get()
        {
            var studentsModels = new List<StudentModels>();
            studentsModels.InjectFrom(_studentEngine.GetAll().ToList());

            return studentsModels;
        }

        // GET: api/Student/5
        public StudentModels Get(int id)
        {
            var studentDomain = _studentEngine.Get(id);

            var studentModels = new StudentModels();
            studentModels.InjectFrom(studentDomain);

            List<EnrollmentModels> enrollmentViewModelList = 
                studentDomain.Enrollments
                            .Select(x => new EnrollmentModels().InjectFrom(x)).Cast<EnrollmentModels>()
                            .ToList();

            studentModels.Enrollments = enrollmentViewModelList;
            return studentModels;
        }

        // POST: api/Student
        public void Post([FromBody]StudentModels value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]StudentModels value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
