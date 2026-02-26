// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Choose the option: ");
        Console.WriteLine("1. Desktop");
        Console.WriteLine("2. Laptop");

        int option=Int32.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
            Desktop desk=new Desktop();
            
            Console.WriteLine("Enter the processor");
            desk.processor=Console.ReadLine();

            Console.WriteLine("Enter the Ram Size");
            desk.ramSize=Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the hard disk Size");
            desk.hardDiskSize=Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the graphic card Size");
            desk.graphicCard=Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the monitor Size");
            desk.monitorSize=Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the power supply volt");
            desk.powerSupplyVolt=Int32.Parse(Console.ReadLine());

            double result=desk.DesktopPriceCalculation();
            Console.WriteLine("Desktop Price is "+result);

            break;

            case 2:
            Laptop laptop=new Laptop();
            
            Console.WriteLine("Enter the processor");
            laptop.processor=Console.ReadLine();

            Console.WriteLine("Enter the Ram Size");
            laptop.ramSize=Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the hard disk Size");
            laptop.hardDiskSize=Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the graphic card Size");
            laptop.graphicCard=Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the display Size");
            laptop.displaySize=Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the power supply volt");
            laptop.batteryVolt=Int32.Parse(Console.ReadLine());

            double result2=laptop.LaptopPriceCalculation();
            Console.WriteLine("Desktop Price is "+result2);
            break;
            default:
            Console.WriteLine("Enter either 1 or 2");
            break;
        }
    }
}