namespace EziBy_Core_ClassLibrary.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public int ItemId { get; set; }
        public int ItemPriceVariantId { get; set; }
        public int ClientId { get; set; }
        public int RatingStar { get; set; }
        public string RatingReview { get; set; }
        public bool Active { get; set; }
    }
}