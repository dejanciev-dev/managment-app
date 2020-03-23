using CsvHelper.Configuration;
using ManagementApp.Application.Invoices.ViewModels.Export;
using ManagementApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementApp.Infrastructure.Files.Maps
{
    public class InvoiceRecordMap : ClassMap<InvoiceRecord>
    {
        public InvoiceRecordMap()
        {
        }
    }
}