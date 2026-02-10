namespace Strings
{
    class Program
    {
        static double CalculateTotalArea()
        {
            List<IArea> shapes=new List<IArea>();
            shapes.Add(new Circle(10));
            shapes.Add(new Rectangle(5,4));
            shapes.Add(new Triangle(3,6));

            double total=0;
            foreach (IArea item in shapes)
            {
                total+=item.Calculatearea();
            }

            return Math.Round(total, 2, MidpointRounding.AwayFromZero);
        }
        public static void Main()
        {
            double result=CalculateTotalArea();
            Console.WriteLine(result);
        }
    }
}