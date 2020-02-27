using ManagementApp.Application.Common.Interfaces;
using ManagementApp.Application.Invoices.Queries;
using ManagementApp.Application.Invoices.ViewModels;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ManagementApp.Application.Invoices.Handlers
{
    public class GetUserInvoicesQueryHandler : IRequestHandler<GetUserInvoicesQuery, IList<InvoiceViewModel>>
    {
        private readonly IApplicationDbContext _context;

        public GetUserInvoicesQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IList<InvoiceViewModel>> Handle(GetUserInvoicesQuery request, CancellationToken cancellationToken)
        {
            var invoices = await _context.Invoices.Include(i => i.InvoiceItems)
                .Where(i => i.CreatedBy == request.User).ToListAsync();
            var vm = invoices.Select(i => new InvoiceViewModel
            {
                AmountPaid = i.AmountPaid,
                Date = i.Date,
                Discount = i.Discount,
                DiscountType = i.DiscountType,
                DueDate = i.DueDate,
                From = i.From,
                Id = i.Id,
                InvoiceNumber = i.InvoiceNumber,
                Logo = i.Logo,
                PaymentTerms = i.PaymentTerms,
                Tax = i.Tax,
                TaxType = i.TaxType,
                To = i.To,
                InvoiceItems = i.InvoiceItems.Select(i => new InvoiceItemViewModel
                {
                    Id = i.Id,
                    Item = i.Item,
                    Quantity = i.Quantity,
                    Rate = i.Rate
                }).ToList()
            }).ToList();
            return vm;
        }
    }
}