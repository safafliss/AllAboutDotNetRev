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
    public class ChambreConfiguration : IEntityTypeConfiguration<Chambre>
    {
        public void Configure(EntityTypeBuilder<Chambre> builder)
        {
            builder.HasOne(ch => ch.Clinique)
                .WithMany(cl => cl.Chambres)
                .HasForeignKey(ch => ch.CliniqueFK);
                //.OnDelete(DeleteBehavior.Cascade);
        }
    }
}
