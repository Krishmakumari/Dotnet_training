using System;

public class Grade
{
    public static void GradeMain()
    {
        Console.WriteLine("Enter grade: ");
        string? g=Console.ReadLine();

        switch (g)
        {
            case "E":
            Console.WriteLine("Excellent");
            break;
            case "V":
            Console.WriteLine("Very Good");
            break;
            case "G":
            Console.WriteLine("Good");
            break;
            case "A":
            Console.WriteLine("Average");
            break;
            case "F":
            Console.WriteLine("Fail");
            break;
            default:
            Console.WriteLine("Enter valid grade");
            break;
        }
    }
}