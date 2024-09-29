using EziBy_Core_WebAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace EziBy_Core_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BranchController : ControllerBase

    {
        private readonly ILogger<SetupController> _logger;
        private readonly EziByDbContext _dbContext;
        public BranchController(ILogger<SetupController> logger, EziByDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        //[Route("api/[controller]/GetABranch")]
        public IActionResult GetABranch(int BranchId)
        {
            try
            {
                return Ok(_dbContext.Branches.Where(e => e.BranchId == BranchId).First());
            }
            catch (Exception)
            {
                var x = _dbContext.Database.GetConnectionString();
                return Ok(x);
            }
        }

    }
}
