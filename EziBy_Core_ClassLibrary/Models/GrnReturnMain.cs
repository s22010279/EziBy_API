namespace EziBy_Core_ClassLibrary.Models
{
    public class GrnReturnMain
    {
        public int GrnReturnMainId { get; set; }
        public int BranchId { get; set; }
        public int GrnMainId { get; set; }//ref
        public DateTime GrnReturnDate { get; set; }

        public string Remarks { get; set; } = string.Empty;

        public decimal AdditionAmount { get; set; }
        public decimal DeductionAmount { get; set; }

        public bool Posted { get; set; }

        public int Prepared_UserId { get; set; }//ref
        public DateTime Prepared_Date { get; set; }
        public int Modified_UserId { get; set; }//ref
        public DateTime Modified_Date { get; set; }

        //ref 
        public virtual GrnMain? GrnMain { get; set; }
        //public virtual Supplier Supplier { get; set; }
        public virtual ICollection<GrnReturnSub> GrnReturnSubs { get; set; } = new List<GrnReturnSub>();
        public virtual User? User { get; set; }
        public virtual User? User1 { get; set; }
        public virtual Branch? Branch { get; set; }
    }
}
