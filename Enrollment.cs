using System.ComponentModel.DataAnnotations;

namespace Midterm_Examination.Models;

public class Enrollment
{
    public int EnrollmentId { get; set; }

    public int StudentId { get; set; }
    public int CourseId { get; set; }

    [Required]
    public string Semester { get; set; }

    [Range(1.0, 5.0)]
    public double Grade { get; set; }
}
