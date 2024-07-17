namespace EziBy_Core_ClassLibrary.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public int BranchId { get; set; }
        public string SupplierName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Mobile { get; set; } = string.Empty;
        public bool Active { get; set; }

        //references
        public virtual ICollection<GrnMain> GrnMains { get; set; } = new List<GrnMain>();
        public virtual ICollection<SupplierPaymentMain> SupplierPaymentMains { get; set; } = new List<SupplierPaymentMain>();
        public virtual Branch? Branch { get; set; }
    }
}
