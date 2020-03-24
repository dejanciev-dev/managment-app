using CsvHelper.Configuration;
using ManagementApp.Application.Invoices.ViewModels.Export;

namespace ManagementApp.Infrastructure.Files.Maps
{
    public class InvoiceRecordMap : ClassMap<InvoiceRecord>
    {
        public InvoiceRecordMap()
        {
        }
    }
}