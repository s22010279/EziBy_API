namespace EziBy_Core_ClassLibrary.Models
{
    public class DeliveryTime
    {
        public int DeliveryTimeId { get; set; }
        public int BranchId { get; set; }
        public string DeliveryTimeName { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        public bool Active { get; set; }

        //references
        public virtual ICollection<Item> Items { get; set; } = new List<Item>();
        public virtual Branch? Branch { get; set; }
    }
}
