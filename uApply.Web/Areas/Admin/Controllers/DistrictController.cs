using Microsoft.AspNetCore.Mvc;
using uApply.DAL.Repository.IRepository;

namespace uApply.Web.Areas.Admin.Controllers
{
    public class DistrictController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public DistrictController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
