using System;

namespace Assessment_7Jan26
{
    class Program
    {
        static void Main(string[] args)
        {
            Ledger<Transaction> ledger = new Ledger<Transaction>();

            IncomeTransaction income = new IncomeTransaction
            {
                Id = 101,
                Date = DateTime.Now,
                Amount = 500,
                Description = "Income Transaction",
                Source = "Cash"
            };

            ledger.AddEntry(income);
            Console.WriteLine("Income transaction added");

            ExpenseTransaction expense = new ExpenseTransaction
            {
                Id = 102,
                Date = DateTime.Now,
                Amount = -200,
                Description = "Office lunch",
                Category = "Food"
            };

            ledger.AddEntry(expense);
            Console.WriteLine("Expense transaction added");

            Console.WriteLine("\nTotal Amount: " + ledger.CalculateTotal());
        }
    }
}
