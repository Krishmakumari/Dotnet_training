using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace StudentMngmentSystem.ViewModels
{
    public class StudentProfileViewModel
    {
        public int StudentId { get; set; }
        [ValidateNever]
        public string StudentName { get; set; } = null!;
        [ValidateNever]
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Address { get; set; } = null!;
        [ValidateNever]
        public string DepartmentName { get; set; } = null!;
        [ValidateNever]
        public string CourseName { get; set; } = null!;
    }
}
