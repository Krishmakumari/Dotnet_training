class Program
{
    static void Swap(ref int a , ref int b)
    {
        int temp=a;
        a=b;
        b=temp;
    }
    static void SwapOut(int a,int b, out int x,out int y)
    {
        x=b;
        y=a;
    }
    public static void Main()
    {
        System.Console.WriteLine("Enter 1st number: ");
        int x=Int32.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter 2nd number: ");
        int y=Int32.Parse(Console.ReadLine());
        System.Console.WriteLine($"Before swapping: {x} and {y}"); 
        Program.Swap(ref x, ref y);
        System.Console.WriteLine($"After swapping: {x} and {y}");

        int a,b;
        SwapOut(x,y,out a,out b);
        x=a;
        y=b;
        System.Console.WriteLine($"Swap using out: {x} and {y}");

    }
}