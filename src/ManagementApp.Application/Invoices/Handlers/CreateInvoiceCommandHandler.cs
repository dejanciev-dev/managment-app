﻿using AutoMapper;
using ManagementApp.Application.Common.Interfaces;
using ManagementApp.Application.Invoices.Commands;
using ManagementApp.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ManagementApp.Application.Invoices.Handlers
{
    public class CreateInvoiceCommandHandler : IRequestHandler<CreateInvoiceCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CreateInvoiceCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateInvoiceCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Invoice>(request);

            _context.Invoices.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }
}