using System;
public class Largestofthree
{
    public static void LargestofthreeMain()
    {
        Console.WriteLine("Enter three numbers: ");
        int n1=Int32.Parse(Console.ReadLine());
        int n2=Int32.Parse(Console.ReadLine());
        int n3=Int32.Parse(Console.ReadLine());

        ///using nested for loops
        if(n1>n2){
            if(n1>n3){
            Console.WriteLine(n1+" is largest");
            }else if(n3>n1){
                Console.WriteLine(n3+" is largest");
            }
        }
        else if(n2>n1){
            if(n2>n3){
                Console.WriteLine(n2+" is largest");
            }else if(n3>n2){
                Console.WriteLine(n3+" is largest");
            }
            
        }else{
            Console.WriteLine(n3+" is largest");
        }
    }
}