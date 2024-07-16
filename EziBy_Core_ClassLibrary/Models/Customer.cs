namespace EziBy_Core_ClassLibrary.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Mobile { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool Active { get; set; }

        //references
        public virtual ICollection<PosMain> PosMains { get; set; }
        public virtual ICollection<CustomerPaymentMain> CustomerPaymentMains { get; set; }
    }
}
