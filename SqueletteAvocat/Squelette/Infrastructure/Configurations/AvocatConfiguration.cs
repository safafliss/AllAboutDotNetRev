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
    public class AvocatConfiguration : IEntityTypeConfiguration<Avocat>
    {
        public void Configure(EntityTypeBuilder<Avocat> builder)
        {
            builder.HasOne(a => a.Specialite)
                .WithMany(s => s.Avocats)
                .HasForeignKey(a => a.SpecialiteFk);
        }
    }
}
