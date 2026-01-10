// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace EventDelegateDemo
{
    public delegate bool CreateRecord(Product p);

    public delegate void Caller(string str);
    class Program
    {
        public static void ShowMe(string str)
        {
            Console.WriteLine("Show me called");
        }
        public void GenerateBill(string str)
        {
            Console.WriteLine("generate bill called");
        }

        static void Main(string[] args)
        {
            //ProductRepo pRepo=new ProductRepo();
            //CreateRecord AddProduct = new CreateRecord(pRepo.Add);

            //AddProduct(new Product());

            Program p1 = new Program();
            Caller CallMe = new Caller(Program.ShowMe);
            CallMe -= new Caller(p1.GenerateBill);

            CallMe("Lpu");
        }
    }
}