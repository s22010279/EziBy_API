using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EziBy_Core_WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}
