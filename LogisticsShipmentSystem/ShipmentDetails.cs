using System.Text.RegularExpressions;

public class ShipmentDetails :Shipment
{

    public bool ValidateShipmentCode()
    {
        string r=@"^GC#[0-9]{4}$";
        if(Regex.IsMatch(shipmentCode,r))
        {
            return true;
        }
        return false;
    }
    public double CalculateTotalCost()
    {
        double totalCost=0;
        if(transportMode =="Sea")
        {
            totalCost=(weight*15.00)+Math.Sqrt(storageDays);
        }
        else if(transportMode =="Air")
        {
            totalCost=(weight*50.00)+Math.Sqrt(storageDays);
        }
        else if(transportMode =="Land")
        {
            totalCost=(weight*25.00)+Math.Sqrt(storageDays);
        }
        else
        {
            Console.WriteLine("Provide correct transport mode.");
        }
        return totalCost;
    }
}