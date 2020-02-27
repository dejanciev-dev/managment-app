using ManagementApp.Application.Invoices.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementApp.Application.Invoices.Queries
{
    public class GetUserInvoicesQuery : IRequest<IList<InvoiceViewModel>>
    {
        public string User { get; set; }
    }
}