namespace EziBy_Core_ClassLibrary.Models
{
    public partial class ViewedItem
    {
        public int ViewId { get; set; }
        public int BranchId { get; set; }
        public int ClientId { get; set; }//ref
        public int ItemId { get; set; }//ref
        public int ItemPriceVariantId { get; set; }//ref
        public int ViewedCount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastViewed { get; set; }

        //references
        public virtual Branch? Branch { get; set; }
        public virtual Client? Client { get; set; }
        public virtual Item? Item { get; set; }
        public virtual ItemPriceVariant? ItemPriceVariant { get; set; }
    }
}
