using Microsoft.AspNetCore.Mvc;
using System.Linq;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models;
using uApply.Utils.ViewModels.UserVM;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace uApply.Web.Areas.User.Controllers
{
    [Area("User")]
    public class ParentController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public ParentController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var parents = unitOfWork.Parent.GetAll(includeProperties: "Nationality,Town,Title,Gender,Race,Language");
            return View(parents);
        }

        public IActionResult Upsert(int? id)
        {
        

            ParentViewModel parentViewModel = new ParentViewModel()
            {
                Parent = new Parent(),
                Genders = unitOfWork.Gender.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                }),
                Titles = unitOfWork.Title.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                }),
                Races = unitOfWork.Race.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                }),
                Nationalities = unitOfWork.Nationality.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                }),
                Languages = unitOfWork.Language.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                })

            };


            if(id == null) return View(parentViewModel);

            parentViewModel.Parent = unitOfWork.Parent.Get(id.GetValueOrDefault());

            if (parentViewModel.Parent == null) return NotFound();

            return View(parentViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(ParentViewModel parentViewModel)
        {
            if (ModelState.IsValid)
            {

                if (parentViewModel.Parent.Id != 0)
                {
                    Parent objFromDb = unitOfWork.Parent.Get(parentViewModel.Parent.Id);
                }


                if (parentViewModel.Parent.Id == 0)
                {
                    parentViewModel.Parent.TownId = 1;
                    unitOfWork.Parent.Add(parentViewModel.Parent);

                }
                else
                {
                    parentViewModel.Parent.TownId = 1;
                    unitOfWork.Parent.Update(parentViewModel.Parent);
                }
                unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                parentViewModel.Genders = unitOfWork.Gender.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });
                parentViewModel.Titles = unitOfWork.Title.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });
                parentViewModel.Races = unitOfWork.Race.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });
                parentViewModel.Nationalities = unitOfWork.Nationality.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });
                parentViewModel.Languages = unitOfWork.Language.GetAll().Select(g => new SelectListItem
                {
                    Text = g.Name,
                    Value = g.Id.ToString()
                });


                if (parentViewModel.Parent.Id != 0)
                {
                    parentViewModel.Parent = unitOfWork.Parent.Get(parentViewModel.Parent.Id);
                }
            }
            return View(parentViewModel);
        }



        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            var parents = unitOfWork.Parent.GetAll();

            if(parents == null) return Json(new { success = false, message = "Erro while fetching data...." });

            return Json(new {data = parents});
        }

        #endregion

    }
}
