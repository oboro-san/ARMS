using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ARMS.DataAccess.Data.Repository.IRepository;
using ARMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace ARMS.UI.Areas.Staff.Controllers
{
    [Area("Staff")]
    public class StateController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public StateController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            State staff = new State();
            if (id == null)
            {
                return View(staff);
            }

            staff = _unitOfWork.State.Get(id.GetValueOrDefault());
            if (staff == null)
            {
                return NotFound();
            }

            return View(staff);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(State state)
        {
            if (ModelState.IsValid)
            {
                if (state.Id == 0)
                {
                    _unitOfWork.State.Add(state);
                }
                else
                {
                    _unitOfWork.State.Update(state);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }

            return View(state);
        }

        #region API Calls

        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _unitOfWork.State.GetAll() });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var state = _unitOfWork.State.Get(id);
            if (state == null)
            {
                return Json(new { success = false, message = "Error deleting" });
            }
            _unitOfWork.State.Remove(state);
            _unitOfWork.Save();
            return Json(new { success = true, message = "State deleted" });
        }

        #endregion API Calls
    }
}