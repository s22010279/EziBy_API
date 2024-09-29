namespace EziBy_Core_ClassLibrary.Models
{
    public partial class PosSub
    {
        public int PosSubId { get; set; }
        public int BranchId { get; set; }
        public int PosMainId { get; set; }
        public int ItemId { get; set; }
        public int ItemPriceVariantId { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal DiscountedSellingPrice { get; set; }
        public decimal PosQty { get; set; }

        //reference
        public virtual Item? Item { get; set; }
        public virtual PosMain? PosMain { get; set; }
        public virtual ItemPriceVariant? ItemPriceVariant { get; set; }
        public virtual ICollection<PosReturnSub> PosReturnSubs { get; set; } = new List<PosReturnSub>();
        public virtual Branch? Branch { get; set; }
    }
}