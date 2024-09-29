using EziBy_Core_ClassLibrary.Models;
using EziBy_Core_WebAPI.Data;
using EziBy_Core_WebAPI.Functions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Drawing.Drawing2D;

namespace EziBy_Core_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<SetupController> _logger;
        private readonly EziByDbContext _dbContext;
        private readonly Category_Function Category_Function;

        public CategoryController(ILogger<SetupController> logger, EziByDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
            Category_Function = new Category_Function(_dbContext);
        }

        [HttpGet]
        public IActionResult GetCategory(int Id)
        {
            try
            {
                return Ok(Category_Function.GetCategory(Id));
            }
            catch (Exception)
            {
                var x = _dbContext.Database.GetConnectionString();
                return Ok(x);
            }
        }

        [HttpGet]
        public IActionResult GetCategories(int BranchId, bool isActive)
        {
            try
            {
                return Ok(Category_Function.GetCategories(BranchId, isActive));
            }
            catch (Exception)
            {
                var x = _dbContext.Database.GetConnectionString();
                return Ok(x);
            }
        }

        //[HttpPost]
        //public IActionResult AddBrand(Brand brand)
        //{
        //    try
        //    {
        //        bool result = Category_Function.AddBrand(brand);
        //        if (!result) return NotFound();
        //        return Ok();
        //    }
        //    catch (Exception)
        //    {
        //        var x = _dbContext.Database.GetConnectionString();
        //        return Ok(x);
        //    }
        //}

        //[HttpPut]
        //public IActionResult EditBrand(Brand brand)
        //{
        //    try
        //    {
        //        bool result = Category_Function.EditBrand(brand);
        //        if (!result) return NotFound();
        //        return Ok();
        //    }
        //    catch (Exception)
        //    {
        //        var x = _dbContext.Database.GetConnectionString();
        //        return Ok(x);
        //    }
        //}

        //[HttpDelete]
        //public IActionResult DeleteBrand(int Id)
        //{
        //    try
        //    {
        //        bool result = Category_Function.DeleteBrand(Id);
        //        if (!result) return NotFound();
        //        return Ok();
        //    }
        //    catch (Exception)
        //    {
        //        var x = _dbContext.Database.GetConnectionString();
        //        return Ok(x);
        //    }
        //}
    }
}
