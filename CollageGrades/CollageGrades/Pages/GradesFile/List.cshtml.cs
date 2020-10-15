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
    public class ListModel : PageModel
    {
        private readonly IGradesData gradesData;

        [BindProperty(SupportsGet =true)]
        public string SearchTerm { get; set; }
        public IEnumerable<Grades> grades { get; set; }
        public ListModel(IGradesData gradesData)
        {
            this.gradesData = gradesData;
        }
        public void OnGet()
        {
            grades = gradesData.GetByName(SearchTerm);
        }
    }
}
