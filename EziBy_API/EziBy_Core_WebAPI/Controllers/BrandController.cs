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
    public class BrandController : ControllerBase
    {
        private readonly ILogger<SetupController> _logger;
        private readonly EziByDbContext _dbContext;
        private readonly Brand_Function Brand_Function;

        public BrandController(ILogger<SetupController> logger, EziByDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
            Brand_Function = new Brand_Function(_dbContext);
        }

        [HttpGet]
        public IActionResult GetBrand(int Id)
        {
            try
            {
                return Ok(Brand_Function.GetBrand(Id));
            }
            catch (Exception)
            {
                var x = _dbContext.Database.GetConnectionString();
                return Ok(x);
            }
        }

        [HttpGet]
        public IActionResult GetBrands(int BranchId, bool isActive, bool DisplayableInMobileApp)
        {
            try
            {
                return Ok(Brand_Function.GetBrands(BranchId, isActive, DisplayableInMobileApp));
            }
            catch (Exception)
            {
                var x = _dbContext.Database.GetConnectionString();
                return Ok(x);
            }
        }

        [HttpPost]
        public IActionResult AddBrand(Brand brand)
        {
            try
            {
                bool result = Brand_Function.AddBrand(brand);
                if (!result) return NotFound();
                return Ok();
            }
            catch (Exception)
            {
                var x = _dbContext.Database.GetConnectionString();
                return Ok(x);
            }
        }

        [HttpPut]
        public IActionResult EditBrand(Brand brand)
        {
            try
            {
                bool result = Brand_Function.EditBrand(brand);
                if (!result) return NotFound();
                return Ok();
            }
            catch (Exception)
            {
                var x = _dbContext.Database.GetConnectionString();
                return Ok(x);
            }
        }

        [HttpDelete]
        public IActionResult DeleteBrand(int Id)
        {
            try
            {
                bool result = Brand_Function.DeleteBrand(Id);
                if (!result) return NotFound();
                return Ok();
            }
            catch (Exception)
            {
                var x = _dbContext.Database.GetConnectionString();
                return Ok(x);
            }
        }
    }
}
