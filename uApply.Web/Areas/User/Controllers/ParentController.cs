using Microsoft.AspNetCore.Mvc;

namespace uApply.Web.Areas.User.Controllers
{
    [Area("User")]
    public class ParentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
