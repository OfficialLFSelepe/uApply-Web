using Microsoft.AspNetCore.Mvc;
using uApply.DAL.Repository.IRepository;
using uApply.Utils.ViewModels.UserVM;
using uApply.Data.Models;

namespace uApply.Web.Areas.User.Controllers
{
    [Area("User")]
    public class LearnerController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public LearnerController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Upsert(int? id)
        {

            return View();
        }

    }
}
