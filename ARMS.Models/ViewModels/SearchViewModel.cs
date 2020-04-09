using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ARMS.Models.ViewModels
{
    public class SearchViewModel
    {
        public string SelectedOption { get; set; }
        public string value { get; set; }

        public IEnumerable<StudentViewModel> listOfStudents { get; set; }

        public List<SelectListItem> Options { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "student_id", Text = "Student Id" },
            new SelectListItem { Value = "mat_number", Text = "Matric Number" },
            new SelectListItem { Value = "name", Text = "Name"  },
        };
    }
}