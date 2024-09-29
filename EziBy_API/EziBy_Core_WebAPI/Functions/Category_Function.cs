using EziBy_Core_ClassLibrary.Models;
using EziBy_Core_WebAPI.Data;

namespace EziBy_Core_WebAPI.Functions
{
    public class Category_Function(EziByDbContext dbContext)
    {
        public Category GetCategory(int Id)
        {
            Category category = new Category();

            try
            {
                category = dbContext.Categories
                .Where(e => e.CategoryId == Id)
                .Where(e => e.Active)
                .First();
            }
            catch (Exception)
            {

            }

            return category;
        }

        public List<Category> GetCategories(int BranchId, bool isActive)
        {
            List<Category> list = new List<Category>();
            try
            {
                list = dbContext.Categories
                    .Where(e => e.BranchId == BranchId)
                    .Where(e => e.Active == isActive)
                    .OrderBy(e => e.DisplayOrder)
                    .ToList();
            }
            catch (System.Exception)
            {


            }
            return list;
        }
    }
}
