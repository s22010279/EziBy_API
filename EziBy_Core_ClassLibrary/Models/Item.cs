namespace EziBy_Core_ClassLibrary.Models
{
    public partial class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Specification { get; set; }
        public string SKUBarcode { get; set; }
        public string Dimension { get; set; }
        public string ItemImage1 { get; set; }
        public string ItemImage2 { get; set; }
        public string ItemImage3 { get; set; }

        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int DeliveryTimeId { get; set; }
        public int UOMId { get; set; }
        public bool StopReOrder { get; set; }
        public int ReOrderLevel { get; set; }
        public int ReOrderQty { get; set; }

        public bool AllowFractionInQty { get; set; }
        public bool NonExchangable { get; set; }
        public int OneTimePurchasableQty { get; set; }

        public bool IsAvailableInMobileApp { get; set; }
        public bool IsAvailableInPOS { get; set; }
        public bool IsNewArrival { get; set; }
        public bool IsTrending { get; set; }
        public bool IsExpress { get; set; }

        public int TotalSold { get; set; }
        public int TotalClicked { get; set; }
        public decimal AverageRating { get; set; }
        public bool Active { get; set; }
    }
}
