// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public class Program
{
    public static void Main()
    {
        System.Console.WriteLine("Enter the title");
        string title=Console.ReadLine();

        System.Console.WriteLine("Enter the author");
        string author=Console.ReadLine();

        System.Console.WriteLine("Enter the number of pages");
        int noOfPages=Int32.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the due date");
        string date=Console.ReadLine();
        DateTime dueDate=DateTime.Parse(date);

        System.Console.WriteLine("Enter the return date ");
        string rdate=Console.ReadLine();
        DateTime returnedDate=DateTime.Parse(rdate); //this takes the input in "DD-MM-YYYY" format
        // DateTime returnedDate=DateTime.ParseExact(rdate); //this takes input in "MM-DD-YYYY" format
        // DateTime returnedDate=DateTime.ParseExact(rdate,"MM/dd/yyyy"); //this will take the input in exact format

        System.Console.WriteLine("Enter the days to read");
        int daysToRead=Int32.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the daily late fee Rate");
        int fee=Int32.Parse(Console.ReadLine());

        Book bObj=new Book(title,author,noOfPages,dueDate,returnedDate);

        Console.WriteLine("Average Pages Read Per Day : "+bObj.AveragePagesReadPerDay(daysToRead));

        Console.WriteLine("Late Fee :" +bObj.CalculateLateFee(fee) );
    }
}