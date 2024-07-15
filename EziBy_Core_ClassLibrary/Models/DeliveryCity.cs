namespace EziBy_Core_ClassLibrary.Models
{
    public class DeliveryCity
    {
        public int DeliveryCityId { get; set; }
        public string DeliveryCityName { get; set; }
        public decimal DeliveryCharge { get; set; }
        public int DisplayOrder { get; set; }
        public bool Active { get; set; }
    }
}
