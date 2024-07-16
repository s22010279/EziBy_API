namespace EziBy_Core_ClassLibrary.Models
{
    public partial class SubCategory
    {
        public int SubCategoryId { get; set; }
        public int CategoryId { get; set; }
        public string SubCategoryName { get; set; } = string.Empty;
        public string SubCategoryImage { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        public bool Active { get; set; }
    }
}
