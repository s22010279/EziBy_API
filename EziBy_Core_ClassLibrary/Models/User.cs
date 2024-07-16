namespace EziBy_Core_ClassLibrary.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserGUID { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string UserFullName { get; set; } = string.Empty;
        public bool Active { get; set; } = true;
        public string Remarks { get; set; } = string.Empty;

        //references
        public virtual ICollection<GrnMain> GrnMains { get; set; }
        public virtual ICollection<GrnMain> GrnMains1 { get; set; } //for 2nd foreign key ref

        public virtual ICollection<PosMain> PosMains { get; set; }
        public virtual ICollection<PosMain> PosMains1 { get; set; } //for 2nd foreign key ref

        public virtual ICollection<GrnReturnMain> GrnReturnMains { get; set; }
        public virtual ICollection<GrnReturnMain> GrnReturnMains1 { get; set; } //for 2nd foreign key ref

        public virtual ICollection<PosReturnMain> PosReturnMains { get; set; }
        public virtual ICollection<PosReturnMain> PosReturnMains1 { get; set; } //for 2nd foreign key ref

        public virtual ICollection<CustomerPaymentMain> CustomerPaymentMains { get; set; }
        public virtual ICollection<CustomerPaymentMain> CustomerPaymentMains1 { get; set; } //for 2nd foreign key ref

        public virtual ICollection<SupplierPaymentMain> SupplierPaymentMains { get; set; }
        public virtual ICollection<SupplierPaymentMain> SupplierPaymentMains1 { get; set; } //for 2nd foreign key ref
    }
}
