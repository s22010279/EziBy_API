using EziBy_Core_WebAPI.Data;
using EziBy_Core_WebAPI.Functions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace EziBy_Core_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BranchController : ControllerBase

    {
        private readonly ILogger<SetupController> _logger;
        private readonly EziByDbContext _dbContext;
        private readonly Branch_Function Branch_Function;

        public BranchController(ILogger<SetupController> logger, EziByDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
            Branch_Function = new Branch_Function(_dbContext);
        }

        [HttpGet]
        public IActionResult GetBranch(int Id)
        {
            try
            {
                return Ok(Branch_Function.GetBranch(Id));
            }
            catch (Exception)
            {
                var x = _dbContext.Database.GetConnectionString();
                return Ok(x);
            }
        }

        [HttpGet]
        public IActionResult GetBranches(bool isActive)
        {
            try
            {
                return Ok(Branch_Function.GetBranches(isActive));
            }
            catch (Exception)
            {
                var x = _dbContext.Database.GetConnectionString();
                return Ok(x);
            }
        }
    }
}
