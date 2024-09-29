namespace EziBy_Core_ClassLibrary.Models
{
    public class WishList
    {
        public int WishListId { get; set; }
        public int BranchId { get; set; }
        public int ClientId { get; set; }
        public int ItemId { get; set; }
        public int ItemPriceVariantId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        //references
        public virtual Branch? Branch { get; set; }
        public virtual Client? Client { get; set; }
        public virtual Item? Item { get; set; }
        public virtual ItemPriceVariant? ItemPriceVariant { get; set; }
    }
}
