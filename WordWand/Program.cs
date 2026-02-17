using System.Text.RegularExpressions;

public class Program
{
    public static string StrReverse(string str)
    {
        string r=@"^[A-Za-z ]+$";
        string ans="";
        if(!Regex.IsMatch(str,r))
        {
            return "Invalid Sentence";
        }
        string[] strArr=str.Split(' ',StringSplitOptions.RemoveEmptyEntries);

        if(strArr.Length%2==0)
        {
            
            for(int i=strArr.Length-1;i>=0;i--)
            {
                ans+=strArr[i]+" ";
            }
            return ans;
        }
        else
        {
            foreach(var w in strArr)
            {
                
                char[] arr=w.ToCharArray();
                Array.Reverse(arr);
                string a=new string(arr);
                ans+=a+" ";
            }
        }
        return ans;
        
    }
    public static void Main()
    {
        Console.WriteLine("Enter senetnce");
        string a=Console.ReadLine();

        Console.WriteLine(Program.StrReverse(a));

    }
    
}