using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Semana10_CodeFirst.Models
{
    public class OfficeAssignment
    {
        [Key]
        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }
        [StringLength(50)]
        [Display(Name ="Office Location")]
        public string Location { get; set; }
        public Boolean Active { get; set; }
        public virtual Instructor Instructor { get; set; }

    }
}