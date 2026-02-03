public class Program
{
    SortedDictionary<string, List<Bike>> groupedBikes=new SortedDictionary<string, List<Bike>>();

    public static void Main()
    {
        BikeUtility utility=new BikeUtility();

        int choice=0;

        while(choice!=3)
        {
            Console.WriteLine("1. Add Bike Details ");
            Console.WriteLine("2. Group by Bikes");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice: ");

            bool validInput = Int32.TryParse(Console.ReadLine(), out choice);
            if (!validInput)
            {
                Console.WriteLine("Invalid input. Please enter a number.\n");
                continue;
            }
            if(choice==1)
            {
                Console.WriteLine("Enter the bike model: ");
                string model=Console.ReadLine();

                Console.WriteLine("Enter the bike brand");
                string brand=Console.ReadLine();

                Console.WriteLine("Enter the price per day");
                int price=Int32.Parse(Console.ReadLine());

                utility.AddBikeDetails(model,brand,price);

                Console.WriteLine("Bikes added successfully.....");

            }
            else if(choice==2)
            {
                var groupBikes=utility.GroupBikesByBrand();

                foreach (var item in groupBikes)
                {
                    Console.WriteLine(item.Key);
                    foreach (Bike bike in item.Value)
                    {
                        Console.WriteLine(bike.Model);
                    }
                    Console.WriteLine();
                }
            }

            else if(choice==3)
            {
                Console.WriteLine("Exiting the program....");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

        }
    }
}