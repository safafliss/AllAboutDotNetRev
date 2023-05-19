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
    public class SpecialiteConfiguration : IEntityTypeConfiguration<Specialite>
    {
        public void Configure(EntityTypeBuilder<Specialite> builder)
        {
            //or
            //builder.HasMany(s => s.Avocats).WithOne(a => a.Specialite).HasForeignKey(s => s.SpecialiteFk).OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
