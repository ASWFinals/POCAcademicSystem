using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace POCAcademicSystem.Controllers
{
    public class EnrollmentController : ApiController
    {
        // GET: api/Enrollment
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Enrollment/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Enrollment
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Enrollment/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Enrollment/5
        public void Delete(int id)
        {
        }
    }
}
