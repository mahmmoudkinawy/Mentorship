using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollageGrades.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CollageGrades.Pages.GradesFile
{
    public class NotFoundModel : PageModel
    {
        public Grades Grades { get; set; }
        public void OnGet()
        {
            Grades = new Grades();
        }
    }
}
