// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter ypur name: ");
//         string? name=Console.ReadLine();

//         Console.WriteLine("Hello, "+name+"!");
//     }
// }


// //prime number
// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter number: ");
//         int? num=Console.Read();
//         bool p=true;
//         if(num<=1){
//             Console.WriteLine("Not prime");
//         }
//         for(int i=2;i*i<=num;i++){
//             if(num%i==0){
//                 p=false;
//             }
//         }
//         if(p){
//             Console.WriteLine("prime");
//         }
//         else{
//             Console.WriteLine(" not prime");
//         }
//     }
// }




// //TryParse , checking if age>=18
// using System;
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter age: ");
//         string? input=Console.ReadLine();
//         if(int.TryParse(input,out int age)){
//             bool isAdult=age>=18;
//             Console.WriteLine("Adult ? :"+isAdult);
//         }
//         else{
//             Console.WriteLine("Invalid age. Please enter a whole number");
//         }
//     }
// }


//convert a legnth from feet to centimeters, 1 foot=30.48cm

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter foot: ");
        string? f=Console.ReadLine();
        double cm=30.98;

        if(double.TryParse(f,out double ans)){
            double a=ans*cm;
            Console.WriteLine(f+ " foot = "+ a+" cm");
        }
        else{
            Console.WriteLine("Invalid input");
        }
    }
}