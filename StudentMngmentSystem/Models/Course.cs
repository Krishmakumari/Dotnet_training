using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace StudentMngmentSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; } = null!;

        public string Duration { get; set; } = null!;

        public decimal Fees { get; set; }

        public int DepartmentId { get; set; }

        [ValidateNever]
        public Department Department { get; set; } = null!;

        [ValidateNever]
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
