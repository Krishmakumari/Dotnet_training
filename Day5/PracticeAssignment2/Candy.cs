using System;

public class Candy
{
    public string flavour { get; set; }
    public int quantity { get; set; }
    public int pricePerpiece { get; set; }
    public double totalPrice { get; set; }
    public double discount { get; set; }

    public bool ValidateCandyFlavour(string flavour)
    {
        bool ans=false;
        if(flavour=="Strawberry" || flavour=="Lemon" || flavour=="Mint")
        {
            ans=true;
        }
        return ans;
    }
}