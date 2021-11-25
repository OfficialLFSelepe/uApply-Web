using Microsoft.AspNetCore.Mvc;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models.Education;

namespace uApply.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SchoolController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public SchoolController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var schools = unitOfWork.School.GetAll(includeProperties: "Town");

            return View(schools);
        }

        public IActionResult Upsert(int? id)
        {
            School school = new School();

            if (id == null) return View(school);

            school = unitOfWork.School.Get(id.GetValueOrDefault());

            if (school == null) return NotFound();

            return View(school);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(School school)
        {
            if (ModelState.IsValid)
            {

                if (school.Id != 0)
                {
                    var objFromDb = unitOfWork.Parent.Get(school.Id);
                }


                if (school.Id == 0)
                {
                    school.TownId = 1;
                    unitOfWork.School.Add(school);
                }
                else
                {
                    school.TownId = 1;
                    unitOfWork.School.Update(school);
                }
                unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }

            return View(school);
        }
    }
}
