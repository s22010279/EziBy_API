namespace EziBy_Core_ClassLibrary.Models
{
    public class ItemPriceVariant
    {
        public int ItemPriceVariantId { get; set; }
        public int ItemId { get; set; } //ref
        public decimal MRP { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal POS_MaxDiscountPercentage { get; set; }
        public decimal POS_MaxDiscountAmount { get; set; }
        public decimal MOB_DiscountPercentage { get; set; }
        public decimal MOB_DiscountAmount { get; set; }
        public bool Active { get; set; }
    }
}
