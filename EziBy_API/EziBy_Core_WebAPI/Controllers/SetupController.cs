using EziBy_Core_ClassLibrary.Models;
using EziBy_Core_WebAPI.Data;
using EziBy_Core_WebAPI.Functions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace EziBy_Core_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SetupController : ControllerBase
    {
        private readonly ILogger<SetupController> _logger;
        private readonly EziByDbContext _dbContext;
        private readonly Setup_Function Setup_Function;

        public SetupController(ILogger<SetupController> logger, EziByDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
            Setup_Function = new Setup_Function(dbContext);
        }

        [HttpGet]
        //[Route("api/[controller]/GetASetup")]
        public IActionResult GetSetup(int Id)
        {
            try
            {
                Setup setup = Setup_Function.GetSetup(Id);
                if (setup.SetupId == 0)
                    return NotFound();

                return Ok(setup);
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult GetSetups(bool isActive, int BranchId)
        {
            try
            {
                return Ok(Setup_Function.GetSetups(isActive, BranchId));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
