using FluentValidation;
using ManagementApp.Application.Invoices.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementApp.Application.Invoices.Validators
{
    public class CreateInvoiceCommandValidator : AbstractValidator<CreateInvoiceCommand>
    {
        public CreateInvoiceCommandValidator()
        {
            RuleFor(v => v.AmountPaid).NotNull();
            RuleFor(v => v.Date).NotNull();
            RuleFor(v => v.From).NotEmpty().MinimumLength(3);
            RuleFor(v => v.To).NotEmpty().MinimumLength(3);
            RuleFor(v => v.InvoiceItems).SetValidator(new InvoiceItemPropertyValidator());
        }
    }
}