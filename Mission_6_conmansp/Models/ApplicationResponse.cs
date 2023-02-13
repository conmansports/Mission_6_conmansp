using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission_6_conmansp.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int FormID { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Category { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public int Year { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Director { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        [StringLength(25)]
        public string Notes { get; set; }
    }
}
