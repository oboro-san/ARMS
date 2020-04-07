using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ARMS.DataAccess.Data.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace ARMS.UI.Areas.Staff.Controllers
{
    [Area("Staff")]
    public class StudentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private const string VALIDATION_ERROR = "The request failed due to a validation error";

        public StudentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        #region Api Calls

        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _unitOfWork.Student.GetAllE();
            return Json(new { data = allObj });
        }

        #endregion Api Calls
    }
}