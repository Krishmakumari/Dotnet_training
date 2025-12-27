using System;

public class SaleTransaction
{
    public string InvoiceNo { get; set; }
    public string CustomerName { get; set; }
    public string ItemName { get; set; }
    public int Quantity { get; set; }
    public float PurchaseAmount { get; set; }
    public float SellingAmount { get; set; }

    SaleTransaction LastTransaction=null;
    bool HasLastTransaction=true;

    string ProfitOrLossStatus ="";
    float ProfitOrLossAmount =0;
    float ProfitMarginPercent =0;

    public void Register()
    {
        
        InvoiceNo=Console.ReadLine();
        System.Console.WriteLine($"Enter Invoice No: <{InvoiceNo}>");

        
        CustomerName=Console.ReadLine();
        System.Console.WriteLine($"Enter Customer Name: <{CustomerName}>");

        ItemName=Console.ReadLine();
        System.Console.WriteLine($"Enter Item Name: <{ItemName}>");


        Quantity=Int32.Parse(Console.ReadLine());
        System.Console.WriteLine($"Enter Quantity: <{Quantity}>");

        
        PurchaseAmount=float.Parse(Console.ReadLine());
        System.Console.WriteLine($"Enter Purchase Amount (total): <{PurchaseAmount}");

        
        SellingAmount=float.Parse(Console.ReadLine());
        System.Console.WriteLine($"Enter Selling Amount (total): <{SellingAmount}>");

        if(InvoiceNo=="" || Quantity<0 || PurchaseAmount<0 || SellingAmount<0)
        {
            System.Console.WriteLine("Enter valid inputs");
        }


        System.Console.WriteLine("Transaction saved successfully.");

        if(SellingAmount>PurchaseAmount)
        {
            ProfitOrLossStatus="PROFIT";
            ProfitOrLossAmount=SellingAmount-PurchaseAmount;
        }
        else if(SellingAmount<PurchaseAmount)
        {
            ProfitOrLossStatus="LOSS";
            ProfitOrLossAmount=PurchaseAmount-SellingAmount;
        }
        else if(SellingAmount==PurchaseAmount)
        {
            ProfitOrLossStatus="BREAK-EVEN";
            ProfitOrLossAmount=0;
        }

        ProfitMarginPercent=(ProfitOrLossAmount/PurchaseAmount)*100;
        System.Console.WriteLine($"Status: {ProfitOrLossStatus}");
        System.Console.WriteLine($"Profit/Loss Amount: {ProfitOrLossAmount}");
        System.Console.WriteLine($"Profit Margin (%): {ProfitMarginPercent}");
          HasLastTransaction=true;
            LastTransaction=this;

    }

    public void View()
        {
            if(HasLastTransaction)
            {
                System.Console.WriteLine("--------Last Bill---------");
                System.Console.WriteLine("InvoiceNo: "+LastTransaction.InvoiceNo);
                System.Console.WriteLine("Customer: "+LastTransaction.CustomerName);
                System.Console.WriteLine("Item: "+LastTransaction.ItemName);
                System.Console.WriteLine("Quantity "+LastTransaction.Quantity);
                System.Console.WriteLine("Purchase amount: "+LastTransaction.PurchaseAmount);
                System.Console.WriteLine("Selling Amount: "+LastTransaction.SellingAmount);
                System.Console.WriteLine("Status: "+LastTransaction.ProfitOrLossStatus);
                System.Console.WriteLine("Profit/Loss Amount: "+LastTransaction.ProfitOrLossAmount);
                System.Console.WriteLine("Profit Margin (%): "+LastTransaction.ProfitMarginPercent);
                System.Console.WriteLine("----------------------------");


            }
            else
            {
                System.Console.WriteLine("No bill available. Please create a new bill first.");
            }
        }

         public void Clear()
        {
            HasLastTransaction=false;
            LastTransaction=null;
            System.Console.WriteLine("Last Bill cleared");
        }

}