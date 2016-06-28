using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Model;

namespace POCAcademicSystem.EntityFramework.Mappings
{
    public class ServiceRequestMapping : EntityTypeConfiguration<ServiceRequest>
    {
        public ServiceRequestMapping()
        {
            ToTable("ServiceRequest", "dbo");
            HasKey(s => s.ServiceRequestId);

            //ServiceType
            HasRequired<ServiceType>(s => s.ServiceType)
                .WithRequiredDependent()
                .WillCascadeOnDelete(false);
        }
    }
}
