using System;
using LPU_Common;
using System.Collections.Generic;
using LPU_Entity;
using LPU_DAL;
using LPU_Exceptions;
namespace LPU_BL
{
    public class StudentBL : IStudentCRUD
    {
        StudentDAO sDAO = null;
        /// bad practice, as then there will be already one object present without invokinng the constructor
        /// Student s1 = new Student();
        public StudentBL()
        {
            sDAO = new StudentDAO();
        }
        public bool DropStudentDetails(int id)
        {
            throw new NotImplementedException();
        }

        public bool EnrollStudent(Student sObj)
        {
            return sDAO.EnrollStudent(sObj);

        }

        public Student SearchStudentByID(int rollNo)
        {
            Student s1 = null;
            try
            {
               s1 = sDAO.SearchStudentByID(rollNo);
            }
            catch(LpuException e)
            {
                throw e;
            }
            
            return s1;
        }

        public List<Student> SearchStudentByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool UpdateStudentDetails(int id, Student newObj)
        {
            throw new NotImplementedException();
        }
    }
}
