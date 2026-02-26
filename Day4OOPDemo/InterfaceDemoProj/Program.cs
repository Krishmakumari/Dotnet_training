// See https://aka.ms/new-console-template for more information
Console.WriteLine("Demo on Interface!");

// IAdd m1=new MathClass(); //Alok-Add

// IAddSub m2=new MathClass(); //Alok-Add,Sub

// IAll m3=new MathClass(); //Alok-Add


//Approch 1
Product pObj=new Product();

pObj.ProdID=101;
pObj.Name="Borosil Flask";
pObj.Price=850;



//Approch 2
//Object Initialiser
Product pObj1=new Product(){ProdID=102,Name="Luxor Marker",Price=25};


//Approch 3
//Collection Initialiser

List<Product>prodList=new List<Product>()
{
    new Product(){ProdID=101,Name="Sebamed Body Lotion",Price=1750},
    new Product(){ProdID=102,Name="Bellavita Perfume",Price=860},
    new Product(){ProdID=103,Name="Hotwheel Toy",Price=400},
    new Product(){ProdID=104,Name="Din=sney Bowl",Price=250},
    new Product(){ProdID=105,Name="Axcer 90mg",Price=2450},
    new Product(){ProdID=106,Name="Luxor",Price=65},
};

foreach (var item in prodList)
{
    Console.WriteLine($"{item.ProdID}\t{item.Name}\t{item.Price}")   
}