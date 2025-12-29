// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;
namespace Day8DemoOnCollection
{
    class Program
    {
        public void ArrayDemoFunc()
        {
            //simple array of primitive types

            //ways to declare array 
            //1
            int[] arrNum;
            arrNum =new int[5];

            //2
            int[] arrNum1=new int[3] {10,20,30};

            //3
            string[] cities={"Delhi",
                            "chennai",
                            "Agra",
                            "Pune",
                            "Mumbai",
                            "Jalandhar",
                            "Agartala",
                            "Nashik",
                            "Trichi"};

            Customer[] custArray;
            custArray=new Customer[2];

            custArray[0] = new Customer(); 

            custArray[0].ID=101;
            custArray[0].Name="Alok";

            //init the address class otherwise it'll give error
            custArray[0].BillingAddress=new Address();
            custArray[0].BillingAddress.FlatNo="1802";
            custArray[0].BillingAddress.BuildingName="Sky Tower";
            custArray[0].BillingAddress.Street="Main street";
            custArray[0].BillingAddress.City="Punjab";

            Console.ForegroundColor=ConsoleColor.White;
        }


        static void Main(string[] args)
        {
            Program pObj=new Program();
            pObj.ArrayDemoFunc();
        }
    }
    
}