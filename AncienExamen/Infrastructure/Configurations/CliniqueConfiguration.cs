using ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class CliniqueConfiguration : IEntityTypeConfiguration<Clinique>
    {
        public void Configure(EntityTypeBuilder<Clinique> builder)
        {
            builder.HasMany(cl => cl.Chambres)
                .WithOne(c => c.Clinique)
                .HasForeignKey(c => c.CliniqueFK);
        }
    }
}
