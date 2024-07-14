namespace EziBy_Core_ClassLibrary.Models
{
    public partial class Advertisement
    {
        public int AdvertisementId { get; set; }
        public string AdvertisementImage { get; set; }
        public string AdvertisementLink { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string Slogan { get; set; }
        public int DisplayOrder { get; set; }
        public bool Paid { get; set; }
        public bool Active { get; set; }
    }
}
