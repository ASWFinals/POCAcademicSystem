using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using POCAcademicSystem.Domain.Engine;
using POCAcademicSystem.Domain.Model;

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
        public IEnumerable<StudentDomain> Get()
        {
            var result = _studentEngine.GetAll();

            return result;
        }

        // GET: api/Student/5
        public StudentDomain Get(int id)
        {
            var studentDomain = _studentEngine.Get(id);

            return studentDomain;
        }

        // POST: api/Student
        public void Post([FromBody]StudentDomain value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]StudentDomain value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
