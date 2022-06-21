using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF.Models//.Metadata
{
    public partial class CourseMetadata
    {
        [Display(Name = "Course Id")]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(50)]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; } = null!;

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Course Description")]
        public string CourseDescription { get; set; } = null!;

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Credit Hours")]
        public byte CreditHours { get; set; }
        [StringLength(250)]
        public string? Curriculum { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(500)]
        public string? Notes { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Active")]
        public bool IsActive { get; set; }
    }

    public partial class EnrollmentMetadata
    {
        [Display(Name = "Enrollement Id")]
        public int EnrollmentId { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Student Id")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Scheduled Class Id")]
        public int ScheduledClassId { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Enrollment Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime EnrollmentDate { get; set; }
    }

    public partial class ScheduledClassMetadata
    {
        [Display(Name = "Scheduled Class Id")]
        public int ScheduledClassId { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Course Id")]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]

        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "End Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]

        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(40)]
        [Display(Name = "Instructor Name")]
        public string InstructorName { get; set; } = null!;

        [Required(ErrorMessage = "Required")]
        [StringLength(20)]
        public string Location { get; set; } = null!;

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Class Status Id")]

        public int Scsid { get; set; }

    }

    public partial class ScheduledClassStatusMetadata
    {
        [Display(Name = "Class Status Id")]
        public int Scsid { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(50)]
        [Display(Name = "Class Status")]
        public string Scsname { get; set; } = null!;

    }

    public partial class StudentMetadata
    {
        [Display(Name = "Student Id")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(20)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Required")]
        [StringLength(20)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;
        [StringLength(20)]
        public string? Major { get; set; }
        [StringLength(50)]
        public string? Address { get; set; }
        [StringLength(25)]
        public string? City { get; set; }
        [StringLength(2)]
        public string? State { get; set; }
        [StringLength(10)]
        [Display(Name = "Zip Code")]
        [DataType(DataType.PostalCode)]
        public string? ZipCode { get; set; }
        [StringLength(13)]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(60)]
        public string Email { get; set; } = null!;
        [StringLength(100)]
        [Display(Name = "Photo Url")]
        public string? PhotoUrl { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Student Status Id")]
        public int Ssid { get; set; }

    }

    public partial class StudentStatusMetadata
    {
        [Display(Name = "Student Status Id")]
        public int Ssid { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(30)]
        [Display(Name = "Student Status")]
        public string Ssname { get; set; } = null!;
        [StringLength(250)]
        public string? Ssdescription { get; set; }

    }
}
