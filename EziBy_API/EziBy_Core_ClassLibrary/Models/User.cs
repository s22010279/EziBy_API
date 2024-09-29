namespace EziBy_Core_ClassLibrary.Models
{
    public class User
    {
        public int UserId { get; set; }
        public int BranchId { get; set; }
        public string UserGUID { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string UserFullName { get; set; } = string.Empty;
        public bool Active { get; set; } = true;
        public string Remarks { get; set; } = string.Empty;

        //references
        public virtual Branch? Branch { get; set; }
        public virtual ICollection<GrnMain> GrnMains { get; set; } = new List<GrnMain>();
        public virtual ICollection<GrnMain> GrnMains1 { get; set; } = new List<GrnMain>(); //for 2nd foreign key ref

        public virtual ICollection<PosMain> PosMains { get; set; } = new List<PosMain>();
        public virtual ICollection<PosMain> PosMains1 { get; set; } = new List<PosMain>(); //for 2nd foreign key ref

        public virtual ICollection<GrnReturnMain> GrnReturnMains { get; set; } = new List<GrnReturnMain>();
        public virtual ICollection<GrnReturnMain> GrnReturnMains1 { get; set; } = new List<GrnReturnMain>(); //for 2nd foreign key ref

        public virtual ICollection<PosReturnMain> PosReturnMains { get; set; } = new List<PosReturnMain>();
        public virtual ICollection<PosReturnMain> PosReturnMains1 { get; set; } = new List<PosReturnMain>(); //for 2nd foreign key ref

        public virtual ICollection<CustomerPaymentMain> CustomerPaymentMains { get; set; } = new List<CustomerPaymentMain>();
        public virtual ICollection<CustomerPaymentMain> CustomerPaymentMains1 { get; set; } = new List<CustomerPaymentMain>(); //for 2nd foreign key ref

        public virtual ICollection<SupplierPaymentMain> SupplierPaymentMains { get; set; } = new List<SupplierPaymentMain>();
        public virtual ICollection<SupplierPaymentMain> SupplierPaymentMains1 { get; set; } = new List<SupplierPaymentMain>();     //for 2nd foreign key ref
    }
}
