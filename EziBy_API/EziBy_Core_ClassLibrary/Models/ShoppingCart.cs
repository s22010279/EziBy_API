namespace EziBy_Core_ClassLibrary.Models
{
    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; }
        public int BranchId { get; set; }
        public int ClientId { get; set; }//ref
        public int ItemId { get; set; }//ref
        public int ItemPriceVariantId { get; set; }//ref
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        //references
        public virtual Client? Client { get; set; }
        public virtual Item? Item { get; set; }
        public virtual ItemPriceVariant? ItemPriceVariant { get; set; }
        public virtual Branch? Branch { get; set; }
    }
}
