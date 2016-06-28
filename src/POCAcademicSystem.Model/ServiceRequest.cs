using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCAcademicSystem.Model
{
    public class ServiceRequest
    {
        public int ServiceRequestId { get; set; }
        public short ServiceTypeId { get; set; }
        public DateTime? RequestDateTime { get; set; }
        public DateTime? ResponseDateTime { get; set; }

        public virtual ServiceType ServiceType { get; set; }
    }
}
