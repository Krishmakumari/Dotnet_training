using System;

public class Quadratic
{
    public static void QuadraticMain()
    {
        Console.WriteLine("Enter a,b,c: ");
        double a=double.Parse(Console.ReadLine());
        double b=double.Parse(Console.ReadLine());
        double c=double.Parse(Console.ReadLine());

        double d=b*b-(4*a*c);

        if(d>0){
            double r1 =(-b + Math.Sqrt(d))/(2*a);
            double r2 =(-b - Math.Sqrt(d))/(2*a);
            Console.WriteLine("Roots are distinct, r1 - "+r1 +"and r2 - "+r2);
        }
        else if(d==0){
            double r1 =(-b)/(2*a);
            Console.WriteLine("Roots are equal, r1 - "+r1 );
        }
        else{
            Console.WriteLine("roots are imaginary");
        }
    }
}