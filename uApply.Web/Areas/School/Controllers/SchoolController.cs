using Microsoft.AspNetCore.Mvc;

namespace uApply.Web.Areas.School.Controllers
{
    public class SchoolController : Controller
    {
        [Area("School")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
