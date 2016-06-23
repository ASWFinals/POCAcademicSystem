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
    public class CourseController : ApiController
    {
        private readonly ICourseEngine _courseEngine;

        public CourseController(ICourseEngine courseEngine)
        {
            _courseEngine = courseEngine;
        }

        // GET: api/Course
        public IEnumerable<CourseDomain> Get()
        {
            return _courseEngine.GetAll();
        }

        // GET: api/Course/5
        public CourseDomain Get(int id)
        {
            return _courseEngine.Get(id);
        }

        // POST: api/Course
        public void Post([FromBody]CourseDomain value)
        {
        }

        // PUT: api/Course/5
        public void Put(int id, [FromBody]CourseDomain value)
        {
        }

        // DELETE: api/Course/5
        public void Delete(int id)
        {
            _courseEngine.Delete(id);
        }
    }
}
