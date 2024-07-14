namespace EziBy_Core_ClassLibrary.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string BrandImage { get; set; }
        public int DisplayOrder { get; set; }
        public bool Active { get; set; }
        public bool DisplayableInMobileApp { get; set; }
    }
}
