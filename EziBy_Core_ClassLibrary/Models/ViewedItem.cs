namespace EziBy_Core_ClassLibrary.Models
{
    public class ViewedItem
    {
        public int ViewId { get; set; }
        public int ClientId { get; set; }
        public int ItemId { get; set; }
        public int ItemPriceVariantId { get; set; }
        public int ViewedCount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastViewed { get; set; }
    }
}
