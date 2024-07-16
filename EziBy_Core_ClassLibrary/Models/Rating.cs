namespace EziBy_Core_ClassLibrary.Models
{
    public partial class Rating
    {
        public int RatingId { get; set; }
        public int ItemId { get; set; }
        public int ItemPriceVariantId { get; set; }
        public int ClientId { get; set; }
        public int RatingStar { get; set; }
        public string RatingReview { get; set; } = string.Empty;
        public bool Active { get; set; }


        //references
        public virtual Client Client { get; set; }
        public virtual Item Item { get; set; }
        public virtual ItemPriceVariant ItemPriceVariant { get; set; }
    }
}