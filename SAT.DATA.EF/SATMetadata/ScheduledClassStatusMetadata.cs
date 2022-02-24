using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SAT.DATA.EF//.SATMetadata
{
    public class ScheduledClassStatusMetadata
    {

        //public int SCSID { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Class Status")]
        [StringLength(50, ErrorMessage = "* Value must be 50 characters or less.")]
        public string SCSName { get; set; }
    }
    [MetadataType(typeof(ScheduledClassStatusMetadata))]
    public partial class ScheduledClassStatus { }
}
