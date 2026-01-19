using System;

public class Program
{

    public static int[] ProductExceptSelf(int[] nums)
    {
        int n=nums.Length;
        int[] answer=new int[n];
        int[] prefix=new int[n];
        int[] sufix=new int[n];

        prefix[0]=1;
        for(int i=1;i<n;i++)
        {
            prefix[i]=prefix[i-1]*nums[i-1];
        }

        sufix[n-1]=1;
        for(int i=n-2;i>=0;i--)
        {
            sufix[i]=sufix[i+1]*nums[i+1];
        }
        for(int i=0;i<n;i++)
        {
            answer[i]=prefix[i]*sufix[i];
        }
        return answer;
    }

    public static void Main()
    {
        System.Console.WriteLine("Enter size of array: ");
        int n=Int32.Parse(Console.ReadLine());

        int[] nums = new int[n];
        System.Console.WriteLine("Enter array inputs: ");
        for(int i=0;i<n;i++)
        {
            nums[i]=Int32.Parse(Console.ReadLine());
        }
        System.Console.Write("Array: ");
        for(int i=0;i<n;i++)
        {
            System.Console.Write(nums[i]+" ");
        }
        System.Console.WriteLine();
        int[] ans=ProductExceptSelf(nums);
        System.Console.Write("Product of array except self : ");
        for(int i=0;i<n;i++)
        {
            System.Console.Write(ans[i]+" ");
        }

    }

}
