namespace EziBy_Core_ClassLibrary.Models
{
    public class DeliveryTime
    {
        public int DeliveryTimeId { get; set; }
        public string DeliveryTimeName { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        public bool Active { get; set; }
    }
}
