namespace EziBy_Core_ClassLibrary.Models
{
    public class PosReturnSub
    {
        public int PosReturnSubId { get; set; }
        public int PosReturnMainId { get; set; }
        public int PosMainId { get; set; }
        public int PosSubId { get; set; }
        public decimal ReturnedQty { get; set; }
        public decimal DiscountedSellingPrice { get; set; }
    }
}