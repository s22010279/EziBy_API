namespace EziBy_Core_ClassLibrary.Models
{
    public class GrnReturnSub
    {
        public int GrnReturnSubId { get; set; }
        public int BranchId { get; set; }
        public int GrnReturnMainId { get; set; }//ref
        public int GrnMainId { get; set; }//ref
        public int GrnSubId { get; set; }//ref
        public decimal ReturnedQty { get; set; }

        //references
        public virtual GrnReturnMain? GrnReturnMain { get; set; }
        public virtual GrnMain? GrnMain { get; set; }
        public virtual GrnSub? GrnSub { get; set; }
        public virtual Branch? Branch { get; set; }
    }
}
