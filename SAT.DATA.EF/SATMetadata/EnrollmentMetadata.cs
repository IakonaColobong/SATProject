﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SAT.DATA.EF//.SATMetadata
{
    public class EnrollmentMetadata
    {

        //public int EnrollmentId { get; set; }


        //public int StudentId { get; set; }


        //public int ScheduledClassId { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Enrollment Date")]
        public System.DateTime EnrollmentDate { get; set; }
    }
    [MetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment{ }
}