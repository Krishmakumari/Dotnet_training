using System;

public class Desktop:Computer
{
    public int monitorSize { get; set; }
    public int powerSupplyVolt { get; set; }

    public double DesktopPriceCalculation()
    {
        int processorCost=0;
        if(processor=="i3"){
            processorCost=1500;
        }
        else if(processor=="i5")
        {
            processorCost=3000;
        }
        else if(processor=="i7")
        {
            processorCost=4500;
        }
         Console.WriteLine("Enter correct processor");

        double desktopPrice=processorCost + (ramSize * 200) + (hardDiskSize * 1500) + 
        (graphicCard * 2500) + (monitorSize * 250 ) + (powerSupplyVolt * 20);

        return desktopPrice;
    }
}