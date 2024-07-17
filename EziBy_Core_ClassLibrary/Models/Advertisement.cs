namespace EziBy_Core_ClassLibrary.Models
{
    public partial class Advertisement
    {
        public int AdvertisementId { get; set; }
        public int BranchId { get; set; }
        public string AdvertisementImage { get; set; } = string.Empty;
        public string AdvertisementLink { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string PhoneNumber1 { get; set; } = string.Empty;
        public string PhoneNumber2 { get; set; } = string.Empty;
        public string Slogan { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        public bool Paid { get; set; }
        public bool Active { get; set; }

        //reference
        public virtual Branch? Branch { get; set; }
    }
}