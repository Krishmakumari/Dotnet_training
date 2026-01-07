// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int num1=100;
int num2=200;
int numResult=num1+num2;
System.Console.WriteLine(numResult);

Employee emp1=new Employee();
emp1.EmpID=101;
emp1.EmpName="ALok";
emp1.BSalary=35000;


Employee emp2=new Employee();
emp2.EmpID=102;
emp2.EmpName="Riya";
emp2.BSalary=40000;

Employee empObj=emp1+emp2;
System.Console.WriteLine($"Total sal paid {empObj.BSalary}");
