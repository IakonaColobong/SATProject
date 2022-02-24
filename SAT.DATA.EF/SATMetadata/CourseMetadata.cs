using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SAT.DATA.EF//.SATMetadata
{
    public class CourseMetadata
    {

        //public int CourseId { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Course")]
        [StringLength(50, ErrorMessage = "* Value must be 50 characters or less.")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Description")]
        [UIHint("MultilineText")]
        public string CourseDescription { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Credit Hours")]
        [UIHint("MultilineText")]
        [Range(0, double.MaxValue, ErrorMessage = "* Value must be a valid number greater than 0")]
        public byte CreditHours { get; set; }

     
        [Display(Name = "Cirriculum")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [UIHint("MultilineText")]
        [StringLength(250, ErrorMessage = "* Value must be 250 characters or less.")]
        public string Curriculum { get; set; }

      
        [Display(Name = "Notes")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [UIHint("MultilineText")]
        [StringLength(500, ErrorMessage = "* Value must be 500 characters or less.")]
        public string Notes { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Active")]
      
        public bool IsActive { get; set; }

    }
    [MetadataType(typeof(CourseMetadata))]
    public partial class Course { }
}
