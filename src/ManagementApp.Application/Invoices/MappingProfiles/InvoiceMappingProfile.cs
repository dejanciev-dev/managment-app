using AutoMapper;
using ManagementApp.Application.Invoices.Commands;
using ManagementApp.Application.Invoices.ViewModels;
using ManagementApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementApp.Application.Invoices.MappingProfiles
{
    public class InvoiceMappingProfile : Profile
    {
        public InvoiceMappingProfile()
        {
            CreateMap<Invoice, InvoiceViewModel>();
            CreateMap<InvoiceItem, InvoiceItemViewModel>().ConstructUsing(i => new InvoiceItemViewModel
            {
                Id = i.Id,
                Item = i.Item,
                Quantity = i.Quantity,
                Rate = i.Rate
            });

            CreateMap<InvoiceViewModel, Invoice>();
            CreateMap<InvoiceItemViewModel, InvoiceItem>();

            CreateMap<CreateInvoiceCommand, Invoice>();
        }
    }
}