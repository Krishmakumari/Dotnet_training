// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public class Program
{
    public static void Main()
    {
        System.Console.WriteLine("=========QuickMart Traders========");
        System.Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
        System.Console.WriteLine("2. View Last Transaction");
        System.Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
        System.Console.WriteLine("4. Exit");

        System.Console.Write($"Enter your option: <>");
        int option=0;

        SaleTransaction sObj=new SaleTransaction();
        do{
            option=Int32.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
            sObj.Register();
            break;
            
            case 2:
            sObj.View();
            break;

            case 3:
            sObj.Clear();
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