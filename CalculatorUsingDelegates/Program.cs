using System;

public class Program
{
    public delegate double ArithmeticOperation(double a,double b);

    public static double Add(double a,double b)
    {
        return a+b;
    }

    public static double Subtract(double a,double b)
    {
        return a-b;
    }
    public static double Multiply(double a,double b)
    {
        return a*b;
    }
    public static double Divide(double a,double b)
    {
        if(b==0)
        {
            throw new DivideByZeroException("Divide by zero is not allowed");
        }
        return a/b;
    }

    public static double PerformOperation(ArithmeticOperation operation,double a,double b)
    {
        return operation(a,b);
    }

    public static void Main()
    {
        Console.WriteLine("Enter 1st number");
        double num1=double.Parse(Console.ReadLine());

        Console.WriteLine("Enter 2nd number");
        double num2=double.Parse(Console.ReadLine());

        Console.WriteLine("Choose the valid operations: \n1.add \n2.subtract \n3.multiply \n4.divide");
        string option=Console.ReadLine();
        
        ArithmeticOperation op=null;

        switch(option)
        {
            case "add":
            op=Add;
            break;

            case "subtract":
            op=Subtract;
            break;

            case "multiply":
            op=Multiply;
            break;

            case "divide":
            op=Divide;
            break;

            default:
            Console.WriteLine("Invalid operation");
            break;

        }

        if(op!=null){
        double ans=PerformOperation (op,num1,num2);
        Console.WriteLine("The result is: "+ans);
        }
        else
        {
            Console.WriteLine("Operation not performed");
        }


    }


    
}