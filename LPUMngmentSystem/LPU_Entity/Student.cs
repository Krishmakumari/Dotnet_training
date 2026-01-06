using System;
namespace LPU_Entity
{
    public enum CourseType
    {
        Mechnical=10,
        Electrical20,
        Civil=30,
        CSE=40,
        IT=50
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public CourseType Course { get; set; } //property type enum

    }
