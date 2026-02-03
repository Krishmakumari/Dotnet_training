using System.Runtime.InteropServices.Marshalling;

class Program
{
    public static int[] MultiplicationTable(int num,int limit)
    {
        int[] arr=new int[limit];
        for(int i=0;i<limit;i++)
        {
            arr[i]=num*(i+1);
        }
        return arr;
    }
    public static void Main()
    {
        Console.WriteLine("Enter number for multiplication Table: ");
        int num=Int32.Parse(Console.ReadLine());

        Console.WriteLine("Multiplication till upto : ");
        int limit=Int32.Parse(Console.ReadLine());

        int[] ans=Program.MultiplicationTable(num,limit);

        for(int i=0;i<limit;i++)
        {
            Console.Write(ans[i]+" ");
        }
        }
    
}