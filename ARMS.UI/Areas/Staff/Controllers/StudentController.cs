using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ARMS.DataAccess.Data.Repository.IRepository;
using ARMS.Models;
using ARMS.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ARMS.UI.Areas.Staff.Controllers
{
    [Area("Staff")]
    public class StudentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private static IEnumerable<Student> _listOfStudents;

        public StudentController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult InsertResults(string id)
        {
            //Student staff = new Student();
            //if (id == null)
            //{
            //    return View(staff);
            //}

            //staff = _unitOfWork.State.Get(id.GetValueOrDefault());
            //if (staff == null)
            //{
            //    return NotFound();
            //}

            return View(); //staff);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(SearchViewModel searchViewModel)
        {
            if (ModelState.IsValid)
            {
                if (searchViewModel.SelectedOption == "student_id")
                {
                    //return Json(new { data = _unitOfWork.Student.GetAll(x => x.StudentId == searchViewModel.value) });
                    _listOfStudents = _unitOfWork.Student.GetAll(x => x.StudentId == searchViewModel.value);
                }
                if (searchViewModel.SelectedOption == "mat_number")
                {
                    //return Json(new { data = _unitOfWork.Student.GetAll(x => x.MatNumber == searchViewModel.value) });
                    _listOfStudents = _unitOfWork.Student.GetAll(x => x.MatNumber == searchViewModel.value);
                }
                //return Json(new { data = _unitOfWork.Student.GetAll(x => x.LastName.Contains(searchViewModel.value) || x.FirstName.Contains(searchViewModel.value) || x.MiddleName.(searchViewModel.value)) });
                _listOfStudents = _unitOfWork.Student.GetAll(x => x.LastName.Contains(searchViewModel.value) || x.FirstName.Contains(searchViewModel.value) || x.MiddleName.Contains(searchViewModel.value));
            }

            return View(searchViewModel);
        }

        public JsonResult GetRecords(DataTablesParam param)
        {
            IQueryable<Student> list;
            List<Student> listOfStudents;
            List<StudentViewModel> listOfStudentsVm = new List<StudentViewModel>();

            int pageNo = 1;

            if (param.iDisplayStart >= param.iDisplayLength)
            {
                pageNo = (param.iDisplayStart / param.iDisplayLength) + 1;
            }

            int totalCount = 0;

            if (param.sSearch != null)
            {
                list = _unitOfWork.Student.GetAllQ(x => x.StudentId.Contains(param.sSearch) || x.MatNumber.Contains(param.sSearch) || x.FullName.Contains(param.sSearch));
                totalCount = list.Count();
                listOfStudents = list.OrderBy(x => x.StudentId).Skip((pageNo - 1) * param.iDisplayLength).Take(param.iDisplayLength).ToList();
                foreach (var student in listOfStudents)
                {
                    listOfStudentsVm.Add(_mapper.Map<StudentViewModel>(student));
                }
            }
            else
            {
                list = _unitOfWork.Student.GetAllQ();
                totalCount = list.Count();
                listOfStudents = list.OrderBy(x => x.StudentId).Skip((pageNo - 1) * param.iDisplayLength).Take(param.iDisplayLength).ToList();
                foreach (var student in listOfStudents)
                {
                    student.FullName = student.FullName.Trim();
                    listOfStudentsVm.Add(_mapper.Map<StudentViewModel>(student));
                }
            }

            return Json(new
            {
                aaData = listOfStudentsVm,
                sEcho = param.sEcho,
                iTotalDisplayRecords = totalCount,
                iTotalRecords = totalCount
            });
        }

        #region API Calls

        [HttpGet]
        public IActionResult GetAll()
        {
            string searchValue = "okoh";
            return Json(new { data = _unitOfWork.Student.GetAll(x => x.LastName == searchValue) });
        }

        //[HttpDelete]
        //public IActionResult Delete(int id)
        //{
        //    var state = _unitOfWork.State.Get(id);
        //    if (state == null)
        //    {
        //        return Json(new { success = false, message = "Error deleting" });
        //    }
        //    _unitOfWork.State.Remove(state);
        //    _unitOfWork.Save();
        //    return Json(new { success = true, message = "State deleted" });
        //}

        #endregion API Calls
    }
}