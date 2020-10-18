using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollageGrades.Core;
using CollageGrades.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CollageGrades.Pages.GradesFile
{
    public class DetailModel : PageModel
    {
        private readonly IGradesData gradesData;

        public Grades Grades { get; set; }
        
        [TempData]
        public string Message { get; set; }
        
        public DetailModel(IGradesData gradesData)
        {
            this.gradesData = gradesData;
        }
        
        public IActionResult OnGet(int studentId)
        {
            Grades = gradesData.GetById(studentId);
            if(Grades == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }
    }
}
