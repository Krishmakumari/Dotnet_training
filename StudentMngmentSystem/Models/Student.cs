using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace StudentMngmentSystem.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string StudentName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string Address { get; set; } = null!;

        public int DepartmentId { get; set; }
        public int CourseId { get; set; }

        [ValidateNever]
        public Department Department { get; set; } = null!;
        [ValidateNever]
        public Course Course { get; set; } = null!;
    }
}
