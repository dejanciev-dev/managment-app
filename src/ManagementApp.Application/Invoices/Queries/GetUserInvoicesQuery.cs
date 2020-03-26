using AutoMapper;
using ManagementApp.Application.Common.Interfaces;
using ManagementApp.Application.Invoices.ViewModels;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ManagementApp.Application.Invoices.Queries
{
    public class GetUserInvoicesQuery : IRequest<IList<InvoiceVm>>
    {
        public string User { get; set; }

        public class GetUserInvoicesQueryHandler : IRequestHandler<GetUserInvoicesQuery, IList<InvoiceVm>>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetUserInvoicesQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<IList<InvoiceVm>> Handle(GetUserInvoicesQuery request, CancellationToken cancellationToken)
            {
                var result = new List<InvoiceVm>();
                var invoices = await _context.Invoices
                    .Include(i => i.InvoiceItems)
                    .Where(i => i.CreatedBy == request.User).ToListAsync();

                if (invoices != null)
                {
                    result = _mapper.Map<List<InvoiceVm>>(invoices);
                }
                return result;
            }
        }
    }
}