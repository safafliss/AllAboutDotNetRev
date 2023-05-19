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
    public class PretLivreConfiguration : IEntityTypeConfiguration<PretLivre>
    {
        public void Configure(EntityTypeBuilder<PretLivre> builder)
        {
            builder.HasKey(p => new
            {
                p.AbonneFk,
                p.LivreFk,
                p.DateDebut
            });
            builder.HasOne(p => p.Livre)
                .WithMany(l => l.PretLivres)
                .HasForeignKey(p => p.LivreFk);

            builder.HasOne(p => p.Abonne)
                .WithMany(a => a.PretLivres)
                .HasForeignKey(p => p.AbonneFk);

        }
    }
}
