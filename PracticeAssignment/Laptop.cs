using System;

public class Laptop:Computer
{
    public int displaySize { get; set; }
    public int batteryVolt { get; set; }

    public double LaptopPriceCalculation()
    {
        int processorCost=0;
        if(processor=="i3"){
            processorCost=2500;
        }
        else if(processor=="i5")
        {
            processorCost=5000;
        }
        else if(processor=="i7")
        {
            processorCost=6500;
        }
        else
        {
            Console.WriteLine("Enter correct processor");
        }

        double laptopPrice=processorCost + (ramSize * 200) + (hardDiskSize * 1500) + 
        (graphicCard * 2500) + (displaySize * 250 ) + (batteryVolt * 20);

        return laptopPrice;
    }
}
