using System.ComponentModel.DataAnnotations;

namespace Midterm_Examination.Models;

public class Department
{
    public int DepartmentId { get; set; }

    [Required]
    public string Code { get; set; }

    [Required]
    public string Name { get; set; }

    public string Office { get; set; }
}
