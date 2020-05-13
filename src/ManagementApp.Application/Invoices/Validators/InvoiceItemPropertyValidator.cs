using FluentValidation.Validators;
using ManagementApp.Application.Invoices.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace ManagementApp.Application.Invoices.Validators
{
    public class InvoiceItemPropertyValidator : PropertyValidator
    {
        public InvoiceItemPropertyValidator()
            : base("Property {PropertyName} should not be an empty list.")
        {
        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            return context.PropertyValue is IList<InvoiceItemVm> list && list.Any();
        }
    }
}