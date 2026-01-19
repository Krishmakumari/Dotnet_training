using System;

public class Program
{

    static string RemoveCommonConsonants(string w1, string w2)
    {
        string vowels="aeiouAEIOU";
        string ans="";
        foreach (char c in w1)
        {
            if(vowels.Contains(c) || !w2.ToLower().Contains(char.ToLower(c)))
            {
                ans+=c;
            } 
        }
        return ans;
    }

    static string RemoveConsecutiveDuplicates(string str)
    {
        if(str.Length==0) return str;

        string ans=str[0].ToString();
        for(int i=1;i<str.Length;i++)
        {
            if(str[i]!=str[i-1])
            {
                ans+=str[i];
            }
        }
        return ans;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first word:");
        string word1 = Console.ReadLine();
        
        Console.WriteLine("Enter second word:");
        string word2 = Console.ReadLine();

        string result = RemoveCommonConsonants(word1, word2);

        result = RemoveConsecutiveDuplicates(result);

        Console.WriteLine("Result: " + result);
    }
}
