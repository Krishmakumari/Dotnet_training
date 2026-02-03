using System.Collections.Generic;

public class BikeUtility
{
    SortedDictionary<int,Bike>bikeDetails=new SortedDictionary<int, Bike>();
    public void AddBikeDetails(string model, string brand, int price)
    {
        int key=bikeDetails.Count+1;
        Bike bike=new Bike(){
        Model=model,
        Brand=brand,
        Price=price,
        };

        bikeDetails.Add(key,bike);

    }

    public SortedDictionary<string,List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string,List<Bike>> groupBikes=new SortedDictionary<string, List<Bike>>();

        foreach(KeyValuePair<int,Bike> entry in bikeDetails)
        {
            Bike bike=entry.Value;

            if(!groupBikes.ContainsKey(bike.Brand))
            {
                groupBikes[bike.Brand]=new List<Bike>();
            }

            groupBikes[bike.Brand].Add(bike);

        }
        return groupBikes;
    }

    public SortedDictionary<int,Bike>GetAllBikes()
    {
        return bikeDetails;
    }
   
}