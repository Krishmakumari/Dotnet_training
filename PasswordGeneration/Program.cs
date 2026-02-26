using System;
using System.Text.RegularExpressions;
public class Program
{
    public static string PassGen(string str)
    {
        string r=@"^[A-Z]{4}@(10[0-9]|11[0-5])$";
        string ans="TECH_";
        if(!Regex.IsMatch(str,r))
        {
            return $"{str} is an invalid username.";
        }
        else
        {
            int sum=0;
            for(int i=0;i<4;i++)
            {
                char c=char.ToLower(str[i]);
                sum+=(int) c;
            }
            ans+=sum;
            ans+=str[str.Length-2];
            ans+=str[str.Length-1];
        }

        return ans;
    }

    public static void Main()
    {
        Console.WriteLine("Enter the username: ");
        string str=Console.ReadLine();

        Console.WriteLine($"Password: {Program.PassGen(str)}");

    }
    
}