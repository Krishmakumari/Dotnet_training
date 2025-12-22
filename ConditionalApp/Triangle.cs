using System;

public class Triangle
{
    public static void TriangleMain()
    {
        Console.WriteLine("Enter three sides in cm: ");
        int s1=Int32.Parse(Console.ReadLine());
        int s2=Int32.Parse(Console.ReadLine());
        int s3=Int32.Parse(Console.ReadLine());

        if((s1==s2)&&(s2==s3)){
            Console.WriteLine("Triangle is Equilateral");
        }
        else if(((s1==s2)&&(s2!=s3)) || ((s1!=s2)&&(s2==s3)) || ((s1==s3)&&(s3!=s2))){
            Console.WriteLine("Triangle is Isosceles");
        }
        else{
            Console.WriteLine("Triangle is Scalene");
        }
    }
}