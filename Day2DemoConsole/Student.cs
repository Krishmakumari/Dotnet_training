using System;

namespace Day2DemoConsole;

public class Student
{
    #region fields
    int rollno;
    string name;
    string address;
        
    #endregion

    ///
    /// Default constructor
    /// 
    public Student()
    {
        rollno=100;
        name="dummy";
        address="dummycity";
    }

    ///paramterized constructor
    
    public Student(int id, string name, string city)
    {
        rollno=id;
        this.name=name;
        address=city;
    }

    ///
    /// The method to display the student class
    /// 
    
    public void DisplayDetails(Student s1)
    {
        System.Console.WriteLine("Roll no: {0}\n Name : {1}\n Address : {2}",s1.rollno,s1.name,s1.address);
    }
}