using System;

public class XYQuadrants
{
    public static void XYQuadrantsMain()
    {
        Console.WriteLine("Enter x and y: ");
        int x=Int32.Parse(Console.ReadLine());
        int y=Int32.Parse(Console.ReadLine());

        if(x>0 && y>0){
            Console.WriteLine("Both lies in 1st quadrants");
        }
        else if(x<0 && y>0){
            Console.WriteLine("Both lies in 2nd quadrants");
        }
        else if(x>0 && y<0){
            Console.WriteLine("Both lies in 3rd quadrants");
        }
        else{
            Console.WriteLine("Both lies in 4th quadrants");
        }


    }
}