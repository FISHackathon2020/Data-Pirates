using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataPiratesTeam.Models
{
    public class InfoS
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Major { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Degree { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string University { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Interest { get; set; }
        [Display(Name = "Work Experience")]
        public string Work_Experience { get; set; }

        [StringLength(5, MinimumLength = 1)]
        [Required]
        public string Gpa { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Graduation Date")]
        public string Graduation_Date { get; set; }
    }
}
