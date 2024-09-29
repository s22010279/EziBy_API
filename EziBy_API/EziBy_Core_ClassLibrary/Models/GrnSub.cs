namespace EziBy_Core_ClassLibrary.Models
{
    public class GrnSub
    {
        public int GrnSubId { get; set; }
        public int BranchId { get; set; }
        public int GrnMainId { get; set; }//ref

        public int ItemId { get; set; }//ref
        public int ItemPriceVariantId { get; set; }//ref
        public decimal CostPrice { get; set; }
        public decimal GrnQty { get; set; }

        //references
        public virtual GrnMain? GrnMain { get; set; }
        public virtual Item? Item { get; set; }
        public virtual ItemPriceVariant? ItemPriceVariant { get; set; }
        public virtual ICollection<GrnReturnSub> GrnReturnSubs { get; set; } = new List<GrnReturnSub>();
        public virtual Branch? Branch { get; set; }
    }
}
