class Program
{
    public static void Main()
    {
        
        ShipmentDetails sObj=new ShipmentDetails();

        Console.WriteLine("Enter Shipment code");
        sObj.shipmentCode=Console.ReadLine();


        bool validate=sObj.ValidateShipmentCode();

        if(!validate)
        {
            Console.WriteLine("Invalid shipment Code");
        }
        else
        {
            Console.WriteLine("Enter Transport Mode: ");
            sObj.transportMode=Console.ReadLine();

            Console.WriteLine("Enter Weight: ");
            sObj.weight=double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Storage Days: ");
            sObj.storageDays=Int32.Parse(Console.ReadLine());

            Console.WriteLine($"The total Shipping cost is : {sObj.CalculateTotalCost():F2}");

        }


    }
}