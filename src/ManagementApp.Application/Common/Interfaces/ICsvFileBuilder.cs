using ManagementApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementApp.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildInvoiceFile(IEnumerable<Invoice> records);
    }
}