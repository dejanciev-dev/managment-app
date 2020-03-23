using ManagementApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementApp.Infrastructure.Persistence.Configurations
{
    public class InvoiceItemConfiguration : IEntityTypeConfiguration<InvoiceItem>
    {
        public void Configure(EntityTypeBuilder<InvoiceItem> builder)
        {
            //builder.Property(x => x.Item)
            //    .HasMaxLength(200)
            //    .IsRequired();
        }
    }
}