using System;
public class Leapyear
{
    public static void LeapyearMain()
    {
        Console.WriteLine("Enter a year");
        int n=Int32.Parse(Console.ReadLine());

        if((n%4==0 &&  n%100!=0 ) || n%400==0){
            Console.WriteLine(n+" is a leap year");
        }else{
            Console.WriteLine(n+" is not a leap year");
        }
    }
}