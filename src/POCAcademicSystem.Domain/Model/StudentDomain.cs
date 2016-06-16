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
    public class StudentDomain
    {
        public StudentDomain()
        {
            Enrollments = new List<EnrollmentDomain>();
        }

        [DataMember(EmitDefaultValue = false)]
        public int StudentId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string FirstName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string LastName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Email { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ContactNumber { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime? EnrollmentDate { get; set; }


        [DataMember(EmitDefaultValue = false)]
        public IEnumerable<EnrollmentDomain> Enrollments { get; set; }
    }
}
