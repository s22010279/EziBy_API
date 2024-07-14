namespace EziBy_Core_ClassLibrary.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string CategoryImage { get; set; } = string.Empty;
        public string CategoryHeaderImage { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        public decimal MaxDiscount { get; set; } = 0;
        public bool Active { get; set; }
    }
}
