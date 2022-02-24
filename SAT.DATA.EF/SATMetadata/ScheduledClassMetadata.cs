using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SAT.DATA.EF//.SATMetadata
{
    public class ScheduledClassMetadata
    {

        //public int ScheduledClassId { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Course ID")]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Start Date")]        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public System.DateTime StartDate { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "End Date")]        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public System.DateTime EndDate { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Instructor")]
        [StringLength(40, ErrorMessage = "* Value must be 40 characters or less.")]
        public string InstructorName { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Location")]
        [StringLength(20, ErrorMessage = "* Value must be 20 characters or less.")]
        public string Location { get; set; }


        //public int SCSID { get; set; }


    }
    [MetadataType(typeof(ScheduledClassMetadata))]
    public partial class ScheduledClass { }
}
