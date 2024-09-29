namespace EziBy_Core_ClassLibrary.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public int BranchId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string CategoryImage { get; set; } = string.Empty;
        public string CategoryHeaderImage { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        public decimal MaxDiscount { get; set; } = 0;
        public bool Active { get; set; }

        //references
        public virtual ICollection<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
        public virtual ICollection<Item> Items { get; set; } = new List<Item>();
        public virtual Branch? Branch { get; set; }
    }
}
