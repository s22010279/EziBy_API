namespace EziBy_Core_ClassLibrary.Models
{
    public class GrnMain
    {
        public int GrnMainId { get; set; }
        public int BranchId { get; set; }
        public DateTime GrnDate { get; set; }
        public int SupplierId { get; set; }//ref
        public string SupplierInvoiceNo { get; set; } = string.Empty;
        public DateTime SupplierInvoiceDate { get; set; }
        public string Remarks { get; set; } = string.Empty;
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

        //references
        public virtual Supplier? Supplier { get; set; }
        public virtual User? User { get; set; }
        public virtual User? User1 { get; set; } //for 2nd foreign key ref
        public virtual ICollection<GrnSub> GrnSubs { get; set; } = new List<GrnSub>();
        public virtual ICollection<GrnReturnMain> GrnReturnMains { get; set; } = new List<GrnReturnMain>();
        public virtual ICollection<GrnReturnSub> GrnReturnSubs { get; set; } = new List<GrnReturnSub>();
        public virtual ICollection<SupplierPaymentSub> SupplierPaymentSubs { get; set; } = new List<SupplierPaymentSub>();
        public virtual Branch? Branch { get; set; }
    }
}
