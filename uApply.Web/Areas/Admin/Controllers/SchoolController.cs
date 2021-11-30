using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models.Education;
using uApply.Data.Models.Location;
using uApply.Utils.ViewModels.EducationVM;

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
            var schools = unitOfWork.School.GetAll(includeProperties: "Town,SchoolLevel");
            return View(schools);
        }

        public IActionResult Upsert(int? id)
        {


            SchoolViewModel schoolViewModel = new SchoolViewModel()
            {
                School = new School(),
                Districts = unitOfWork.District.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                }),
                Towns = unitOfWork.Town.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                }),
                SchoolLevels = unitOfWork.SchoolLevel.GetAll().Select(g => new SelectListItem
                 {
                     Text = g.Name,
                     Value = g.Id.ToString()
                 })

            };


            if (id == null) return View(schoolViewModel);

            schoolViewModel.School = unitOfWork.School.Get(id.GetValueOrDefault());

            if (schoolViewModel.School == null) return NotFound();

            return View(schoolViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(SchoolViewModel schoolViewModel)
        {
            if (ModelState.IsValid)
            {

                if (schoolViewModel.School.Id != 0)
                {
                    School objFromDb = unitOfWork.School.Get(schoolViewModel.School.Id);
                }


                if (schoolViewModel.School.Id == 0)
                {
                    unitOfWork.School.Add(schoolViewModel.School);

                }
                else
                {
                    unitOfWork.School.Update(schoolViewModel.School);
                }
                unitOfWork.Save();
                return RedirectToAction(nameof(Profile), new { id = schoolViewModel.School.Id });
            }
            else
            {
                schoolViewModel.Districts = unitOfWork.District.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });
                schoolViewModel.Towns= unitOfWork.Town.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                
                });
                schoolViewModel.SchoolLevels = unitOfWork.SchoolLevel.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()

                });

                if (schoolViewModel.School.Id != 0)
                {
                    schoolViewModel.School = unitOfWork.School.Get(schoolViewModel.School.Id);
                }
            }
            return View(schoolViewModel);
        }

        public IActionResult Profile(int id)
        {
            var schoolVM = new SchoolViewModel();

            var schoolFromDb = unitOfWork.School.GetAll(s => s.Id == id, includeProperties: "Town,SchoolLevel").FirstOrDefault();

            schoolVM.School= schoolFromDb;

            var applications = unitOfWork.SchoolApplication.GetAll(a => a.SchoolId == id, includeProperties: "Learner,Grade");

            if (!applications.Any()) return View(schoolVM);

            schoolVM.Applications = applications;

            return View(schoolVM);
        }


        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            var schools = unitOfWork.School.GetAll();

            if (schools == null) return Json(new { success = false, message = "Erro while fetching data...." });

            return Json(new { data = schools });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var gradeToDelete = unitOfWork.Grade.Get(id);

            if (gradeToDelete == null) return Json(new { success = false, message = "Failed to delete" });

            unitOfWork.Grade.Remove(id);
            unitOfWork.Save();

            return Json(new { success = true, message = "Succesfuly deleted!", id = id });

        }

        //[HttpGet("{id:int}")]
        //public IActionResult GetParent(int id)
        //{
        //    var parent = unitOfWork.Parent.Get(id);

        //    return Json(new { data = parent});
        //}

        //[HttpGet("{parentId:int}")]
        //public IActionResult Learners(int parentId)
        //{
        //    var learners = unitOfWork.Learner.GetAll(l => l.ParentId == parentId);

        //    if (learners == null) return Json(new { success = false, message = "Erro while fetching data...." });

        //    return Json(new { data = learners });
        //}


        #endregion

    }
}
