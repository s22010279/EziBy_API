namespace EziBy_Core_ClassLibrary.Models
{
    public class GrnMain
    {
        public int GrnMainId { get; set; }
        public DateTime GrnDate { get; set; }
        public int SupplierId { get; set; }//ref
        public string SupplierInvoiceNo { get; set; }
        public DateTime SupplierInvoiceDate { get; set; }
        public string Remarks { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal AdditionAmount { get; set; }
        public decimal DeductionAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal NetAmount { get; set; }
        public bool Posted { get; set; }
        public int Prepared_UserId { get; set; }//ref
        public DateTime Prepared_Date { get; set; }
        public int Modified_UserId { get; set; }//ref
        public DateTime Modified_Date { get; set; }
    }
}
