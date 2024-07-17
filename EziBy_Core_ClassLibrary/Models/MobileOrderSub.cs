namespace EziBy_Core_ClassLibrary.Models
{
    public partial class MobileOrderSub
    {
        public int MobileOrderSubId { get; set; }
        public int BranchId { get; set; }
        public string MobileOrderMainId { get; set; } = string.Empty;//ref
        public int ItemId { get; set; }//ref
        public int ItemPriceVariantId { get; set; }//ref
        public int Quantity { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal DiscountedSellingPrice { get; set; }
        public int OrderStatusId { get; set; } // for counting the remaining quantity if rejected it will not add to sum of sold quantity

        //references
        public virtual Item? Item { get; set; }
        public virtual ItemPriceVariant? ItemPriceVariant { get; set; }
        public virtual MobileOrderMain? MobileOrderMain { get; set; }
        public virtual Branch? Branch { get; set; }
    }
}
