namespace EziBy_Core_ClassLibrary.Models
{
    public partial class SubCategory
    {
        public int SubCategoryId { get; set; }

        public int BranchId { get; set; }
        public int CategoryId { get; set; }
        public string SubCategoryName { get; set; } = string.Empty;
        public string SubCategoryImage { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        public bool Active { get; set; }

        //references
        public virtual Category? Category { get; set; }
        public virtual ICollection<Item> Items { get; set; } = new List<Item>();
        public virtual Branch? Branch { get; set; }
    }
}
