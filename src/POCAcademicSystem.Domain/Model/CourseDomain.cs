using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace POCAcademicSystem.Domain.Model
{
    [DataContract]
    [Serializable]
    public class CourseDomain
    {
        public CourseDomain()
        {
            Enrollments = new List<EnrollmentDomain>();
        }

        [DataMember(EmitDefaultValue = false)]
        public int CourseId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Title { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public byte Credits { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string InstructorName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public IEnumerable<EnrollmentDomain> Enrollments { get; set; }
    }
}
