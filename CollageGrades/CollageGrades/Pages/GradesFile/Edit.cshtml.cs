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
    public class EditModel : PageModel
    {
        private readonly IGradesData gradesData;
        [BindProperty]
        public Grades Grades { get; set; }
        public EditModel(IGradesData gradesData)
        {
            this.gradesData = gradesData;
        }
        public IActionResult OnGet(int? studentId)
        {
            if(studentId.HasValue)
            {
                Grades = gradesData.GetById(studentId.Value);
            }
            else
            {
                Grades = new Grades();
            }
            
            if(Grades == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            
            if(Grades.Id > 0 )
            {
                gradesData.Update(Grades);
            }
            else
            {
                gradesData.Add(Grades);
            }

            gradesData.Commit();
            TempData["Message"] = "Student Information Saved.";
            return RedirectToPage("./Detail", new { studentId = Grades.Id });

        }
    }
}
