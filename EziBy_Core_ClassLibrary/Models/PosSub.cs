namespace EziBy_Core_ClassLibrary.Models
{
    public class PosSub
    {
        public int PosSubId { get; set; }
        public int PosMainId { get; set; }
        public int ItemId { get; set; }
        public int ItemPriceVariantId { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal DiscountedSellingPrice { get; set; }
        public decimal PosQty { get; set; }
    }
}
