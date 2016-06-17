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
    public class EnrollmentController : ApiController
    {
        private readonly IEnrollmentEngine _enrollmentEngine;

        //using dependency injection
        public EnrollmentController(IEnrollmentEngine enrollmentEngine)
        {
            _enrollmentEngine = enrollmentEngine;
        }

        // GET: api/Enrollment
        public IEnumerable<EnrollmentDomain> Get()
        {
            return _enrollmentEngine.GetAll();
        }

        // GET: api/Enrollment/5
        public EnrollmentDomain Get(int id)
        {
            return _enrollmentEngine.Get(id);
        }

        // POST: api/Enrollment
        public void Post([FromBody]EnrollmentDomain value)
        {
        }

        // PUT: api/Enrollment/5
        public void Put(int id, [FromBody]EnrollmentDomain value)
        {
        }

        // DELETE: api/Enrollment/5
        public void Delete(int id)
        {
        }
    }
}
