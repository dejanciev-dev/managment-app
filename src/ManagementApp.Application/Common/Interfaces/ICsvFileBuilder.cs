using ManagementApp.Domain.Entities;
using System.Collections.Generic;

namespace ManagementApp.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildInvoiceFile(IEnumerable<Invoice> records);
    }
}