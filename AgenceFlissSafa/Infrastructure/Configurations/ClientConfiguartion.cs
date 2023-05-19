using ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class ClientConfiguartion : IEntityTypeConfiguration<Client>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Client> builder)
        {
            builder.HasOne(cl => cl.Conseiller)
                .WithMany(c => c.Clients)
                .HasForeignKey(cl => cl.ConseillerFK)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
