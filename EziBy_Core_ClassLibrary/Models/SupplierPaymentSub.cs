namespace EziBy_Core_ClassLibrary.Models
{
    public class SupplierPaymentSub
    {
        public int SupplierPaymentSubId { get; set; }
        public int SupplierPaymentMainId { get; set; }
        public int GrnMainId { get; set; }
        public decimal SettledAmount { get; set; }

        //references
        public virtual SupplierPaymentMain SupplierPaymentMain { get; set; }
        public virtual GrnMain GrnMain { get; set; }
    }
}
