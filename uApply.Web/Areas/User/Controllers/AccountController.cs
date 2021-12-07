using Microsoft.AspNetCore.Mvc;
using System.Linq;
using uApply.DAL.Repository.IRepository;
using uApply.Utils.ViewModels.UserVM;

namespace uApply.Web.Areas.User.Controllers
{
    [Area("User")]
    public class AccountController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public AccountController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {

            return View();
        }
        
        public IActionResult Login()
        {
            return View();
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel login)
        {
            if(ModelState.IsValid)
            {
                var parent = unitOfWork.Parent.GetAll(p => p.Email == login.Email).FirstOrDefault();

                if (parent != null)
                {
                    if (parent.Password == login.Password.Trim()) return RedirectToAction("Profile", "Parent", new { id = parent.Id });
                }

                //Add School Email
                var school = unitOfWork.School.GetAll(s => s.Email == login.Email).FirstOrDefault();

                if(school != null)
                {
                    if (school.Password == login.Password.Trim()) return RedirectToAction("Profile", "School", new { area = "Admin", id = school.Id });

                }
            }

            return View();
        }

        
    }
}
