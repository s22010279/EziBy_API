namespace EziBy_Core_ClassLibrary.Models
{
    public class PosReturnSub
    {
        public int PosReturnSubId { get; set; }
        public int BranchId { get; set; }
        public int PosReturnMainId { get; set; }
        public int PosMainId { get; set; }
        public int PosSubId { get; set; }
        public decimal ReturnedQty { get; set; }
        public decimal DiscountedSellingPrice { get; set; }


        //ref
        public virtual PosReturnMain? PosReturnMain { get; set; }
        public virtual PosMain? PosMain { get; set; }
        public virtual PosSub? PosSub { get; set; }
        public virtual Branch? Branch { get; set; }
    }
}