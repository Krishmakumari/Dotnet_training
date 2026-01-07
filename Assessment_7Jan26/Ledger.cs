namespace Assessment_7Jan26
{
    public class Ledger<T> :Transaction
    {
        List<T> TransHistory=new List<T>();

        public void AddEntry(T entry)
        {
            TransHistory.add(entry);
        }


        public List<T> GetTransactionsByDate(DateTime date)
        {
            List<T> result=new List<>();
            foreach(T transaction in TransHistory)
            {
                if(transaction.date.Date==date.Date)
                {
                    result.add(transaction);
                }
            }
            return result;
    }

        

        public float CalculateTotal()
        {
            float Amount=0;
            foreach(T transaction in TransHistory)
            {
                Amount+=transaction.amount;
            }
            return amount;

        }

    }
}
