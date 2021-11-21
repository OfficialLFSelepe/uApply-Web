using Microsoft.AspNetCore.Mvc;

namespace uApply.Web.Areas.Admin.Controllers
{
    public class TownController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
