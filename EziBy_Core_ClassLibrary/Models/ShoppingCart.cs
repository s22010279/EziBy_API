namespace EziBy_Core_ClassLibrary.Models
{
    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; }
        public int ClientId { get; set; }//ref
        public int ItemId { get; set; }//ref
        public int ItemPriceVariantId { get; set; }//ref
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
