using LPU_Common;
using LPU_Entity;
using LPU_Exceptions;
using System;

namespace LPU_DAL
{
    /// <summary>
    /// Student Data Access Object(DAO) class for managing crud operations.
    /// </summary>
    public class StudentDAO : IStudentCRUD
    {
        static List<Student> studentList = null;
        GenericClass<float> genObj = null;
        public StudentDAO()
        {
            genObj = new GenericClass<Student>();

            genObj.SwapMe();
            ///Collecton init
            studentList = new List<Student>()
            {
                ///anonmous object
                new Student() { StudentId = 101, Name = "Alok", Course = CourseType.CSE, Address = "Chandigarh" },
                new Student() { StudentId = 102, Name = "Aliya", Course = CourseType.CSE, Address = "Jalandhar" },
                new Student() { StudentId = 103, Name = "Aman", Course = CourseType.CSE, Address = "Delhi" },
                new Student() { StudentId = 104, Name = "Riya", Course = CourseType.CSE, Address = "Phagwara" },
                new Student() { StudentId = 105, Name = "Rajat", Course = CourseType.CSE, Address = "Kochi" },
            };
        }

        public bool DropStudentDetails(int id)
        {
            throw new NotImplementedException();
        }

        public bool EnrollStudent(Student sObj)
        {
            bool flag = false;
            if(sObj != null)
            {
                studentList.Add(sObj);
                flag = true;

            }
            return flag;
        }

        public Student SearchStudentByID(int rollNo)
        {
            Student myStud = null;
            if(rollNo !=0)
            {
                myStud = studentList.Find(s => s.StudentId == rollNo);
                if(myStud==null)
                {
                    throw new LpuException("Student record not found");
                }
            }
            else
            {
                throw new LpuException("Error generated.....");
            }
            return myStud;
        }

        public List<Student> SearchStudentByName(string name)
        {
            List<Student> data = studentList.FindAll(p => p.Name == name);
            return data;
        }

        public bool UpdateStudentDetails(int id, Student newObj)
        {
            throw new NotImplementedException();
        }
    }
}
