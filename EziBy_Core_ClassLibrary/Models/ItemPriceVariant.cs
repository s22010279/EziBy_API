namespace EziBy_Core_ClassLibrary.Models
{
    public class ItemPriceVariant
    {
        public int ItemPriceVariantId { get; set; }
        public int BranchId { get; set; }
        public int ItemId { get; set; } //ref
        public decimal MRP { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal POS_MaxDiscountPercentage { get; set; }
        public decimal POS_MaxDiscountAmount { get; set; }
        public decimal MOB_DiscountPercentage { get; set; }
        public decimal MOB_DiscountAmount { get; set; }
        public bool Active { get; set; }

        //reference
        public virtual Item? Item { get; set; }
        public virtual ICollection<GrnSub> GrnSubs { get; set; } = new List<GrnSub>();
        public virtual ICollection<PosSub> PosSubs { get; set; } = new List<PosSub>();
        public virtual ICollection<Rating> Ratings { get; set; } = new List<Rating>();
        public virtual ICollection<MobileOrderSub> MobileOrderSubs { get; set; } = new List<MobileOrderSub>();
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();
        public virtual ICollection<ViewedItem> ViewedItems { get; set; } = new List<ViewedItem>();
        public virtual ICollection<WishList> WishLists { get; set; } = new List<WishList>();
        public virtual Branch? Branch { get; set; }
    }
}
