using EziBy_Core_ClassLibrary.Models;
using EziBy_Core_WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EziBy_Core_WebAPI.Functions
{
    public class Brand_Function(EziByDbContext dbContext)
    {
        public Brand GetBrand(int id)
        {
            Brand brand = new Brand();

            try
            {
                brand = dbContext.Brands
                    .Where(e => e.BrandId == id)
                    .First();

            }
            catch (System.Exception)
            {

            }
            return brand;
        }

        public List<Brand> GetBrands(int BranchId, bool isActive, bool DisplayableInMobileApp)
        {
            List<Brand> list = new List<Brand>();
            try
            {
                list = dbContext.Brands
                    .Where(e => e.BranchId == BranchId)
                    .Where(e => e.Active == isActive)
                    .Where(e => e.DisplayableInMobileApp == DisplayableInMobileApp)
                    .OrderBy(e => e.DisplayOrder)
                    .ThenBy(e => e.BrandName)
                    .ToList();
            }
            catch (System.Exception)
            {


            }
            return list;
        }

        public bool AddBrand(Brand brand)
        {
            //validate the data here


            try
            {
                dbContext.Brands.Add(brand);
                dbContext.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }

        public bool DeleteBrand(int id)
        {
            try
            {
                Brand oldData = GetBrand(id);
                if (oldData == null) return false;

                dbContext.Brands.Remove(oldData);
                dbContext.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }

        public bool EditBrand(Brand brand)
        {
            //validate the data here



            try
            {
                Brand oldData = new Brand();
                //loading the old data
                oldData = dbContext.Brands
                    .Where(e => e.BrandId == brand.BrandId)
                    .Where(e => e.BranchId == brand.BranchId)
                    .First();

                if (oldData == null) return false;

                //setting the old data with new data
                oldData.BranchId = brand.BranchId;
                oldData.BrandName = brand.BrandName;
                oldData.BrandImage = brand.BrandImage;
                oldData.DisplayOrder = brand.DisplayOrder;
                oldData.Active = brand.Active;
                oldData.DisplayableInMobileApp = brand.DisplayableInMobileApp;

                //update the record
                dbContext.Entry(oldData).State = EntityState.Modified;

                //saving changes to database
                dbContext.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
        }
    }
}