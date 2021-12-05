using Microsoft.AspNetCore.Mvc;
using uApply.DAL.Repository.IRepository;
using uApply.Data.Models.Location;

namespace uApply.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TownController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public TownController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var towns = unitOfWork.Town.GetAll(includeProperties: "District");
            
            return View(towns);
        }

        public IActionResult Upsert(int? id)
        {
            Town town = new Town();

            if (id == null) return View(town);

            town = unitOfWork.Town.Get(id.GetValueOrDefault());

            if (town == null) return NotFound();

            return View(town);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Town town)
        {
            if (ModelState.IsValid)
            {

                if (town.Id != 0)
                {
                    var objFromDb = unitOfWork.Town.Get(town.Id);
                }


                if (town.Id == 0)
                {
                    town.DistrictId = 1; 
                    unitOfWork.Town.Add(town);
                }
                else
                {
                    town.DistrictId = 1; 
                    unitOfWork.Town.Update(town);
                }
                unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }

            return View(town);
        }

        [HttpGet]
        public IActionResult GetTowns()
        {
            var towns = unitOfWork.Town.GetAll();
            return Json(new {data = towns, success = true});
        }
    }
}
