using EziBy_Core_WebAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace EziBy_Core_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SetupController : ControllerBase
    {
        private readonly ILogger<SetupController> _logger;
        private readonly EziByDbContext _dbContext;

        public SetupController(ILogger<SetupController> logger, EziByDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        //[Route("api/[controller]/GetASetup")]
        public IActionResult GetASetup(int SetupId)
        {
            try
            {
                return Ok(_dbContext.Setups.Where(e => e.SetupId == SetupId).First());
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
