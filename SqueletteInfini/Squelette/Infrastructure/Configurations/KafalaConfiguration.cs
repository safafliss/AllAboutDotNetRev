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
    public class KafalaConfiguration : IEntityTypeConfiguration<Kafala>
    {
        public void Configure(EntityTypeBuilder<Kafala> builder)
        {
            builder.HasKey(k => new
            {
                k.StartDate,
                k.BeneficiaryFk,
                k.DonatorFk
            });
            builder.HasOne(k => k.Beneficiary)
                .WithMany(b => b.Kafalas)
                .HasForeignKey(k => k.BeneficiaryFk);

            builder.HasOne(k => k.Donator)
                .WithMany(d => d.Kafalas)
                .HasForeignKey(k => k.DonatorFk);

        }
    }
}
