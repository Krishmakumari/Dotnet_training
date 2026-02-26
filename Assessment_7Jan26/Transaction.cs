using System;
namespace Assessment_7Jan26
{
    public abstract class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public string Description { get; set; }

        public Transaction(int id, DateTime d, float amount, string description)
        {
            Id=id;
            Date=d;
            Amount=amount;
            Description=description;
        }
    
    }
}