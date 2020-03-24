using ManagementApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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