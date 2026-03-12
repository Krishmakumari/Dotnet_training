using System;

public class Height
{
    public static void HeightMain(){
        Console.WriteLine("Enter height in cm: ");
        string? height=Console.ReadLine();
        int h;
        if(!int.TryParse(height,out h)){
            Console.WriteLine("Invalid input");
        }
        if(h<150){
            Console.WriteLine("Dwarf");
        }
        else if(h>=150 && h<165){
            Console.WriteLine("Average");
        }
        else if(h>=165 && h<190){
            Console.WriteLine("Tall");
        }else{
            Console.WriteLine("Abnormal");
        }
    }
}