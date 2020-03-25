using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ARMS.DataAccess.Data.Repository.IRepository;
using ARMS.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ARMS.UI.Areas.Staff.Controllers
{
    [Area("Staff")]
    public class StateController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private const string VALIDATION_ERROR = "The request failed due to a validation error";

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

        private void PopulateModel(State state, IDictionary values)
        {
            if (values.Contains("NameOfState"))
                state.NameOfState = Convert.ToString(values["NameOfState"]);

            //if (values.Contains("OrderDate"))
            //    order.OrderDate = values["OrderDate"] != null ? Convert.ToDateTime(values["OrderDate"]) : (DateTime?)null;

            //if (values.Contains("ShipCity"))
            //    order.ShipCity = Convert.ToString(values["ShipCity"]);
        }

        #region API Calls

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions)
        {
            return Json(await DataSourceLoader.LoadAsync(_unitOfWork.State.GetAllQ(), loadOptions));
        }

        [HttpPost]
        public async Task<IActionResult> Insert(string values)
        {
            var newState = new State();
            PopulateModel(newState, JsonConvert.DeserializeObject<IDictionary>(values));

            if (!TryValidateModel(newState))
                return BadRequest(VALIDATION_ERROR);

            _unitOfWork.State.Add(newState);
            await _unitOfWork.SaveAsync();
            return Json(newState.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Update(int key, string values)
        {
            var state = await _unitOfWork.State.FirstOrDefaultAsync(item => item.Id == key);
            PopulateModel(state, JsonConvert.DeserializeObject<IDictionary>(values));

            if (!TryValidateModel(state))
                return BadRequest(VALIDATION_ERROR);

            await _unitOfWork.SaveAsync();
            return Ok();
        }

        #endregion API Calls
    }
}