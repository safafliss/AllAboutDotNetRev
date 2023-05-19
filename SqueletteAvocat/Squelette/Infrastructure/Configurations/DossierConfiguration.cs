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
    public class DossierConfiguration : IEntityTypeConfiguration<Dossier>
    {
        public void Configure(EntityTypeBuilder<Dossier> builder)
        {
            builder.HasKey(d => new
            {
                d.AvocatFk,
                d.ClientFk,
                d.DateDepot
            });
            //or 
            //builder.HasKey(d => new { d.AvocatFK, d.ClientFK, d.DateDepot });
            //builder.HasOne(d => d.Client).WithMany(c => c.Dossiers).HasForeignKey(d => d.ClientFK);
            //builder.HasOne(d => d.Avocat).WithMany(c => c.Dossiers).HasForeignKey(d => d.AvocatFK);
        }
    }
}
