namespace EziBy_Core_ClassLibrary.Models
{
    public class SupplierPaymentSub
    {
        public int SupplierPaymentSubId { get; set; }
        public int BranchId { get; set; }
        public int SupplierPaymentMainId { get; set; }
        public int GrnMainId { get; set; }
        public decimal SettledAmount { get; set; }

        //ref
        public virtual SupplierPaymentMain? SupplierPaymentMain { get; set; }
        public virtual GrnMain? GrnMain { get; set; }
        public virtual Branch? Branch { get; set; }
    }
}
