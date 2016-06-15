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
    public class EnrollmentDomain
    {
        [DataMember(EmitDefaultValue = false)]
        public int EnrollmentId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int CourseId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int StudentId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public byte? Grade { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public CourseDomain Course { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public StudentDomain Student { get; set; }
    }
}
