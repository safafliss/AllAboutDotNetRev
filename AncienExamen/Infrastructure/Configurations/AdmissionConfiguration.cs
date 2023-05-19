using ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class AdmissionConfiguration : IEntityTypeConfiguration<Admission>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Admission> builder)
        {
            builder.HasKey(a => new { a.DateAdmission, a.ChambreFK, a.PatientFK });
        }
    }
}
