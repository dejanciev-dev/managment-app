using ManagementApp.Application.Invoices.ViewModels;
using MediatR;
using System.Collections.Generic;

namespace ManagementApp.Application.Invoices.Queries
{
    public class GetUserInvoicesQuery : IRequest<IList<InvoiceVm>>
    {
        public string User { get; set; }
    }
}