namespace EziBy_Core_ClassLibrary.Models
{
    public class GrnSub
    {
        public int GrnSubId { get; set; }
        public int GrnMainId { get; set; }//ref

        public int ItemId { get; set; }//ref
        public int ItemPriceVariantId { get; set; }//ref
        public decimal CostPrice { get; set; }
        public decimal GrnQty { get; set; }
    }
}
