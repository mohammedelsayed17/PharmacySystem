using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharmacySystem.Models;
using PharmacySystem.Services;

namespace PharmacySystem.Controllers
{
    public class MedicineController : Controller
    {
        private readonly IMedicineRepository _repository;

        public MedicineController(IMedicineRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index(string? search)
        {
            var meds = _repository.GetAll(search);
            return View(meds);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create() => View();

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Create(Medicine med)
        {
            if (!ModelState.IsValid) return View(med);
            _repository.Add(med);
            _repository.Save();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id)
        {
            var med = _repository.GetById(id);
            if (med == null) return NotFound();
            return View(med);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Edit(Medicine med)
        {
            if (!ModelState.IsValid) return View(med);
            _repository.Update(med);
            _repository.Save();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            var med = _repository.GetById(id);
            if (med == null) return NotFound();
            return View(med);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _repository.Delete(id);
            _repository.Save();
            return RedirectToAction("Index");
        }
    }
}
