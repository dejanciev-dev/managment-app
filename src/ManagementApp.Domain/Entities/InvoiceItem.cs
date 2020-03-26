using ManagementApp.Domain.Common;

namespace ManagementApp.Domain.Entities
{
    public class InvoiceItem : AuditableEntity
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public string Item { get; set; }
        public double Quantity { get; set; }
        public double Rate { get; set; }
        public Invoice Invoice { get; set; }
    }
}