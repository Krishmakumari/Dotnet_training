// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public class Program
{
    public Candy CalculateDiscountedPrice(Candy can)
    {
        can.totalPrice=can.quantity*can.pricePerpiece;

        if(can.flavour=="Strawberry"){
            can.discount= can.totalPrice - ((can.totalPrice*15)/100);
        }
        else if(can.flavour=="Lemon"){
            can.discount= can.totalPrice - ((can.totalPrice*10)/100);
        }
        else if(can.flavour=="Mint"){
            can.discount= can.totalPrice - ((can.totalPrice*5)/100);
        }

        return can;
    }
    public static void Main()
    {
        Console.WriteLine("Enter the flavour : ");
        string flavour=Console.ReadLine();

        Console.WriteLine("Enter the quantity : ");
        int quantity=Int32.Parse(Console.ReadLine());

        Console.WriteLine("Enter the price per piece : ");
        int pricePerpiece=Int32.Parse(Console.ReadLine());

        Candy can=new Candy();
        Program p=new Program();

        can.flavour=flavour;
        can.pricePerpiece=pricePerpiece;
        can.quantity=quantity; 
        if(can.ValidateCandyFlavour(flavour))
        {
            p.CalculateDiscountedPrice(can);
            Console.WriteLine("Total Price : "+can.totalPrice);
            Console.WriteLine("Discount Price : " + can.discount);
        }
        else{
            Console.WriteLine("Enter valid flavor");
        }

    }
}