using Microsoft.AspNetCore.Mvc;

namespace uApply.Web.Areas.Admin.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
