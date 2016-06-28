using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCAcademicSystem.Model;

namespace POCAcademicSystem.EntityFramework.Mappings
{
    public class ServiceTypeMapping : EntityTypeConfiguration<ServiceType>
    {
        public ServiceTypeMapping()
        {
            ToTable("ServiceType", "dbo");
            HasKey(s => s.ServiceTypeId);

            Property(s => s.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
        }
    }
}
