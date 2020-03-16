namespace ManagementApp.Application.Invoices.ViewModels
{
    public class InvoiceItemViewModel
    {
        public long Id { get; set; }
        public string Item { get; set; }
        public double Quantity { get; set; }
        public double Rate { get; set; }

        public double Amount
        {
            get
            {
                return Quantity * Rate;
            }
        }
    }
}