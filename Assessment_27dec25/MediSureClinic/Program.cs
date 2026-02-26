// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public class Program
{
    public static void Main()
    {
        System.Console.WriteLine("=========MediSure Patient Details========");
        System.Console.WriteLine("1. Create New Bill (Enter Patient Details)");
        System.Console.WriteLine("2. View Last Bill");
        System.Console.WriteLine("3. Clear Last Bill");
        System.Console.WriteLine("4. Exit");

        System.Console.Write("Enter your option: <");
        int option=0;

        MediSure mObj=new MediSure();
        do{
            option=Int32.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
            mObj.Register();
            break;
            
            case 2:
            mObj.View();
            break;

            case 3:
            mObj.Clear();
            break;

            case 4:
            System.Console.WriteLine("Thank you. Application closed normally.");
            break;
            default:
            System.Console.WriteLine("Enter valid input");
            break;
        }
        }while (option!=4);
    }
}