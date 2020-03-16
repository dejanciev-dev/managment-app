using AutoMapper;
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
        private readonly IMapper _mapper;

        public GetUserInvoicesQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IList<InvoiceViewModel>> Handle(GetUserInvoicesQuery request, CancellationToken cancellationToken)
        {
            var result = new List<InvoiceViewModel>();
            var invoices = await _context.Invoices
                .Include(i => i.InvoiceItems)
                .Where(i => i.CreatedBy == request.User).ToListAsync();

            if (invoices != null)
            {
                result = _mapper.Map<List<InvoiceViewModel>>(invoices);
            }
            return result;
        }
    }
}