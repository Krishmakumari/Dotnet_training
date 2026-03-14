using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace StudentMngmentSystem.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [Required]
        public string DepartmentName { get; set; } = null!;

        public string? Description { get; set; }

        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
