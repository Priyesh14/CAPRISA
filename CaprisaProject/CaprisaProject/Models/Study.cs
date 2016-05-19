using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace CaprisaProject.Models
{
    public enum Status
    {
        [Display(Name = "Awaiting Approval")]
        Appro,
        Ongoing,
        [Display(Name = "In-site Training")]
        Training,
        Completed,
        [Display(Name = "Data Analysis Stage")]
        Data,
        [Display(Name = "In Follow Up Phase")]
        Phase
    }

    public class Study
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [Display(Name ="Study Code")]
        public string StudyCode { get; set; }

        [Required]
        [Display(Name ="Study Title")]
        [DataType(DataType.Text,ErrorMessage ="Please Enter Study Title/Name for clarification.")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Status of Study")]
        public Status Status { get; set; }

        public virtual ICollection <Enrollment> Enrollments { get; set; }
    }
}