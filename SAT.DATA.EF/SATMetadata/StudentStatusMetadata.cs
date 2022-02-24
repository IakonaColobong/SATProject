using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SAT.DATA.EF//.SATMetadata
{
    public class StudentStatusMetadata
    {
        //[Required(ErrorMessage = "*")]
        //[Display(Name = "First Name")]
        //[StringLength(20, ErrorMessage = "* Value must be 20 characters or less.")]
        //public int SSID { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Status")]
        [StringLength(30, ErrorMessage = "* Value must be 30 characters or less.")]
        public string SSName { get; set; }


       
        [Display(Name = "Description")]
        [UIHint("MultilineText")]
        [StringLength(250, ErrorMessage = "* Value must be 250 characters or less.")]
        public string SSDescription { get; set; }
    }
    [MetadataType(typeof(StudentStatusMetadata))]
    public partial class StudentStatus { }
}
