using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CollageGrades.Core
{
    public class Grades
    {
        public int Id { get; set; }
        [Required]
        [StringLength(80)]
        public string FullName { get; set; }
        [Required]
        public int SettingNumber { get; set; }
        [Required]
        public double InformationSystem { get; set; }
        [Required]
        public double Introduction { get; set; }
        [Required]
        public double Math1 { get; set; }
        [Required]
        public double Physics { get; set; }
        [Required]
        public double English { get; set; }
        [Required]
        public double DescriteMath { get; set; }
        [Required]
        public double Programming { get; set; }
        [Required]
        [StringLength(8)]
        public string Status { get; set; }
    }
}
