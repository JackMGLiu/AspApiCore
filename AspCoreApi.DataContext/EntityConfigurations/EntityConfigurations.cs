using System;
using System.Collections.Generic;
using System.Text;
using AspCoreApi.Infrastructure.Core.EntityConfigurations;
using AspCoreApi.Models.Angular;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspCoreApi.DataContext.EntityConfigurations
{
    public class ClientConfiguration : EntityBaseConfiguration<Client>
    {
        public override void ConfigureDerived(EntityTypeBuilder<Client> builder)
        {
            builder.Property(x => x.Balance);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(100);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Phone).HasMaxLength(50);
        }
    }
}
