using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;//added for notations

namespace SAT.DATA.EF//.SATMetadata
{
    



        public class StudentMetadata
        {


            //public int StudentId { get; set; }
            [Required(ErrorMessage = "*")]
            [Display(Name = "First Name")]
            [StringLength(20, ErrorMessage = "* Value must be 20 characters or less.")]
            public string FirstName { get; set; }

            [Required(ErrorMessage = "*")]
            [Display(Name = "Last Name")]
            [StringLength(20, ErrorMessage = "* Value must be 20 characters or less.")]
            public string LastName { get; set; }

            [DisplayFormat(NullDisplayText = "N/A")]
            [Display(Name = "Major")]
            [StringLength(15, ErrorMessage = "* Value must be 15 characters or less.")]
            public string Major { get; set; }

            [DisplayFormat(NullDisplayText = "N/A")]
            [Display(Name = "Address")]
            [StringLength(50, ErrorMessage = "* Value must be 50 characters or less.")]
            public string Address { get; set; }

            [DisplayFormat(NullDisplayText = "N/A")]
            [Display(Name = "City")]
            [StringLength(25, ErrorMessage = "* Value must be 25 characters or less.")]
            public string City { get; set; }

            [DisplayFormat(NullDisplayText = "N/A")]
            [Display(Name = "State")]
            [StringLength(2, ErrorMessage = "* Value must be 2 characters or less.")]
            public string State { get; set; }

            [DisplayFormat(NullDisplayText = "N/A")]
            [Display(Name = "Zip Code")]
            [StringLength(10, ErrorMessage = "* Value must be 10 characters or less.")]
            public string ZipCode { get; set; }

            [DisplayFormat(NullDisplayText = "N/A")]
            [Display(Name = "Phone")]
            [StringLength(13, ErrorMessage = "* Value must be 13 characters or less.")]
            public string Phone { get; set; }

            [Required(ErrorMessage = "*")]
            [Display(Name = "Email")]
            [StringLength(60, ErrorMessage = "* Value must be 60 characters or less.")]
            public string Email { get; set; }

            [DisplayFormat(NullDisplayText = "N/A")]
            [Display(Name = "Photo Path")]
            [UIHint("MultilineText")]
            [StringLength(100, ErrorMessage = "* Value must be 100 characters or less.")]
            public string PhotoUrl { get; set; }

            //[Required(ErrorMessage = "*")]
            //public int SSID { get; set; }



        }//end public Metadata
   
            [MetadataType(typeof(StudentMetadata))]
            public partial class Student { }
}//end namespace




