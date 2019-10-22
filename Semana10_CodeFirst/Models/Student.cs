using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Semana10_CodeFirst.Models
{
    public class Student : Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        [Display(Name ="Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        [DefaultValue(true)]
        public Boolean Active { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}